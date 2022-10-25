using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinForms_Proektirovanie_LR_3
{
	public partial class Form1 : Form
	{
		OpenFileDialog ofd;
		SaveFileDialog sfd;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// добавим пустые строки
			dgv_10.Rows.Add();
			dgv_10.Rows.Add();
			dgv_10.Rows[0].HeaderCell.Value = "Корни";
			dgv_10.Rows[1].HeaderCell.Value = "Проверка";
			dgv_10.RowHeadersWidth = 90;

			dgv_14.Rows.Add();
			dgv_14.Rows.Add();
			dgv_14.Rows[0].HeaderCell.Value = "Корни";
			dgv_14.Rows[1].HeaderCell.Value = "Проверка";
			dgv_14.RowHeadersWidth = 90;

			ofd = new OpenFileDialog();
			sfd = new SaveFileDialog();

			chart.Series[0].LegendText = "y = f(x)";
			chart.Series[0].ChartType = SeriesChartType.Line;
			chart.Series[0].Color = Color.DodgerBlue;

			chart.Series.Add("По шагам локализации");
			chart.Series[1].ChartType = SeriesChartType.Column;
			chart.Series[1]["PixelPointWidth"] = "2";
			chart.Series[1].Color = Color.Red;

			chart.Series.Add("Корни уравнения");
			chart.Series[2].ChartType = SeriesChartType.Point;
			chart.Series[1]["PixelPointWidth"] = "2";
			chart.Series[2].Color = Color.Orange;

			clear_dgv_roots();
			clear_dgv_check();
		}

		private void btn_read_koef_from_file_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.Cancel)
				return;
			string[] str = File.ReadAllText(ofd.FileName).Split('|');
			try
			{
				tb_a3.Text = str[0];
				tb_a2.Text = str[1];
				tb_a1.Text = str[2];
				tb_a0.Text = str[3];
				tb_A.Text = str[4];
				tb_B.Text = str[5];
				tb_steps.Text = str[6];
			} catch(Exception)
			{
				MessageBox.Show("Данные в файле имеют неверный формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_save_koef_in_file_Click(object sender, EventArgs e)
		{
			if (sfd.ShowDialog() == DialogResult.Cancel)
				return;
			File.WriteAllText(sfd.FileName, tb_a3.Text + "|" + tb_a2.Text + "|" + tb_a1.Text + "|" + tb_a0.Text + "|" +
										tb_A.Text + "|" + tb_B.Text + "|" + tb_steps.Text);
			MessageBox.Show("Данные успешно записаны", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public double? y(double x)
		{
			try
			{
				return x * x * x * Convert.ToDouble(tb_a3.Text.Replace('.', ',')) +
						   x * x * Convert.ToDouble(tb_a2.Text.Replace('.', ',')) +
							   x * Convert.ToDouble(tb_a1.Text.Replace('.', ',')) +
								   Convert.ToDouble(tb_a0.Text.Replace('.', ','));

			} catch (Exception)
			{
				MessageBox.Show("Проверьте корректность введенных данных y(x)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		private void btn_draw_graphic_Click(object sender, EventArgs e)
		{
			try
			{
				if (Convert.ToInt16(tb_steps.Text) < 3)
					tb_steps.Text = "20";
			} catch (Exception)
			{
				tb_steps.Text = "20";
			}

			chart.Series[0].Points.Clear();
			chart.Series[1].Points.Clear();
			chart.Series[2].Points.Clear();

			try
			{
				double x = Convert.ToDouble(tb_A.Text.Replace('.', ','));

				if (x >= Convert.ToDouble(tb_B.Text.Replace('.', ',')))
				{
					MessageBox.Show("Левая граница А не может быть больше, чам правая В", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				while (x <= Convert.ToDouble(tb_B.Text.Replace('.', ',')))
				{
					chart.Series[0].Points.AddXY(x, y(x));
					x += 0.1;
				}
				chart.Series[0].Points.AddXY(x, y(x));

				x = Convert.ToDouble(tb_A.Text.Replace('.', ','));
				double step = ( Math.Abs(x) + Math.Abs(Convert.ToDouble(tb_B.Text.Replace('.', ','))) ) / Convert.ToDouble(tb_steps.Text.Replace('.', ','));

				chart.Series[1].Points.AddXY(x, y(x));
				while (x < Convert.ToDouble(tb_B.Text.Replace('.', ',')))
				{
					x += step;
					chart.Series[1].Points.AddXY(x, y(x));
				}
			} catch (Exception)
			{
				MessageBox.Show("Проверьте корректность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void clear_dgv_roots()
		{
			dgv_10[0, 0].Value = 0;
			dgv_10[1, 0].Value = 0;
			dgv_10[2, 0].Value = 0;
			dgv_14[0, 0].Value = 0;
			dgv_14[1, 0].Value = 0;
			dgv_14[2, 0].Value = 0;
		}
		public void clear_dgv_check()
		{
			dgv_10[0, 1].Value = 0;
			dgv_10[1, 1].Value = 0;
			dgv_10[2, 1].Value = 0;
			dgv_14[0, 1].Value = 0;
			dgv_14[1, 1].Value = 0;
			dgv_14[2, 1].Value = 0;
		}

		private void btn_find_root_Click(object sender, EventArgs e)
		{
			btn_draw_graphic_Click(null, null);
			clear_dgv_roots();

			double A, B;
			int steps;
			try
			{
				A = Convert.ToDouble(tb_A.Text.Replace('.', ','));
				B = Convert.ToDouble(tb_B.Text.Replace('.', ','));
				steps = Convert.ToInt16(tb_steps.Text);

				if (A >= B)
					return;
			}
			catch(Exception)
			{
				return;
			}

			double step = (Math.Abs(A) + Math.Abs(B)) / steps;

			double x = A;
			double x1, x2, eps = 1E-14;
			List<double> roots = new List<double>();
			int root_count = 0;
			chart.Series[2].Points.Clear();
			for (int i = 0; i < steps; i++)
			{
				x1 = x;
				x2 = x + step;
				if (y(x1) * y(x2) < 0)
				{
					while (x1 - ((x1 + x2) / 2) > eps || x2 - ((x1 + x2) / 2) > eps)
						if (y(x1) * y((x1 + x2) / 2) < 0)
							x2 = (x1 + x2) / 2;
						else
							x1 = (x1 + x2) / 2;
					
					roots.Add((x1 + x2) / 2);
					
					dgv_10[root_count, 0].Value = Math.Round(roots.ElementAt(root_count), 10).ToString();
					dgv_14[root_count, 0].Value = Math.Round(roots.ElementAt(root_count), 14).ToString();

					chart.Series[2].Points.AddXY(roots.ElementAt(root_count), y(roots.ElementAt(root_count)));
					chart.Series[2].Points[root_count].Label = dgv_10[root_count, 0].Value.ToString();

					root_count++;
				}
				x += step;
			}

			for (int i = root_count; i < 3; i++)
			{
				dgv_10[i, 0].Value = "Нет корней";
				dgv_14[i, 0].Value = "Нет корней";
			}
		}

		// Решение кубического уравнения по формуле Кардано
		private static void Kardano(double a3, double a2, double a1, double a0, ref int tip, ref double[] x)
		{
			double eps = 1E-14;
			double p = (3 * a3 * a1 - a2 * a2) / (3 * a3 * a3);
			double q = (2 * a2 * a2 * a2 - 9 * a3 * a2 * a1 + 27 * a3 * a3 * a0) / (27 * a3 * a3 * a3);
			double det = q * q / 4 + p * p * p / 27;
			if (Math.Abs(det) < eps)
				det = 0;
			if (det > 0)
			{
				tip = 1; // один вещественный, два комплексных корня
				x = new double[1];
				double u = -q / 2 + Math.Sqrt(det);
				u = Math.Exp(Math.Log(u) / 3);
				double yy = u - p / (3 * u);
				x[0] = yy - a2 / (3 * a3); // первый корень
				//x[1] = -(u - p / (3 * u)) / 2 - a2 / (3 * a3);
				//x[2] = Math.Sqrt(3) / 2 * (u + p / (3 * u));
			}
			else
			{
				if (det < 0)
				{
					tip = 2; // три вещественных корня
					x = new double[3];
					double fi;
					if (Math.Abs(q) < eps) // q=0
						fi = Math.PI / 2;
					else
					{
						if (q < 0) // q<0
							fi = Math.Atan(Math.Sqrt(-det) / (-q / 2));
						else // q<0
							fi = Math.Atan(Math.Sqrt(-det) / (-q / 2)) + Math.PI;
					}
					double r = 2 * Math.Sqrt(-p / 3);
					x[0] = r * Math.Cos(fi / 3) - a2 / (3 * a3);
					x[1] = r * Math.Cos((fi + 2 * Math.PI) / 3) - a2 / (3 * a3);
					x[2] = r * Math.Cos((fi + 4 * Math.PI) / 3) - a2 / (3 * a3);
				}
				else // det=0
				{
					if (Math.Abs(q) < eps)
					{
						tip = 4; // 3-х кратный 
						x = new double[] { -a2 / (3 * a3) };
						//x[0] = -a2 / (3 * a3); // 3-х кратный 
					}
					else
					{
						tip = 3; // один и два кратных
						x = new double[2];
						double u = Math.Exp(Math.Log(Math.Abs(q) / 2) / 3);
						if (q < 0)
							u = -u;
						x[0] = -2 * u - a2 / (3 * a3);
						x[1] = u - a2 / (3 * a3);
					}
				}
			}
		} // end Kardano

		public void Solve_quadr(double a, double b, double c, ref int tip, ref double[] x)
		{
			double D = Math.Pow(b, 2) - 4 * a * c;
			if (D > 0 || D == 0)
			{
				tip = 5;
				x = new double[2];
				x[0] = (-b + Math.Sqrt(D)) / (2 * a);
				x[1] = (-b - Math.Sqrt(D)) / (2 * a);
			}
			else
			{
				tip = 6;
				x = new double[0];
			}
		}

		public void Solve_linear(double a, double b, ref int tip, ref double[] x)
		{
			//0 = ax + b
			//-ax = b
			//x = - b / a
			tip = 7;
			x = new double[] { -b / a };
		}
		private void btn_check_root_Click(object sender, EventArgs e)
		{
			clear_dgv_check();
			//тип уравнения
			int tip = 0;
			// корни
			double[] x = new double[0];
			try
			{
				double a3 = Convert.ToDouble(tb_a3.Text.Replace('.', ','));
				double a2 = Convert.ToDouble(tb_a2.Text.Replace('.', ','));
				double a1 = Convert.ToDouble(tb_a1.Text.Replace('.', ','));
				double a0 = Convert.ToDouble(tb_a0.Text.Replace('.', ','));

				if (a3 != 0)
				{
					//кубическое уравнение
					Kardano(a3, a2, a1, a0, ref tip, ref x);
				} else if (a3 == 0 && a2 != 0)
				{
					// квадратное уравнение
					x = new double[] { 0, 0 };
					Solve_quadr(a2, a1, a0, ref tip, ref x);
				} else if (a3 == 0 && a2 == 0 && a1 != 0)
				{
					//прямая линия
					x = new double[] { 0 };
					Solve_linear(a1, a0, ref tip, ref x);
				} else if (a3 == 0 && a2 == 0 && a1 == 0 && a0 == 0)
				{
					//корней бесконечное множество
					tip = 8;
					x = new double[0];
				}
				else
				{
					//корней нет
					tip = 9;
					x = new double[0];
				}
				
			}
			catch (Exception)
			{
				MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//попали в ошибку - вываливаемся из метода
				return;
			}

			Array.Sort(x);
			for (int i = 0; i < x.Length; i++)
			{
				dgv_10[i, 1].Value = Math.Round(x[i], 10).ToString();
				dgv_14[i, 1].Value = Math.Round(x[i], 14).ToString();
			}
			for (int i = x.Length; i < 3; i++)
			{
				dgv_10[i, 1].Value = "Корня нет";
				dgv_14[i, 1].Value = "Корня нет";
			}

			switch (tip)
			{
				case 1:
					label_type.Text = "Кубическое уравнение\nИмеется один действительный корень x1 и два комплексных корня";
					break;
				case 2:
					label_type.Text = "Кубическое уравнение\nИмеется три различных действительных корня";
					break;
				case 3:
					label_type.Text = "Кубическое уравнение\nИмеется один отличающийся и два кратных действительных корня";
					break;
				case 4:
					label_type.Text = "Кубическое уравнение\nИмеется три кратных действительных корня";
					break;
				case 5:
					label_type.Text = "Квадратическое уравнение\nИмеется два корня";
					break;
				case 6:
					label_type.Text = "Квадратическое уравнение\nДействительных корней нет";
					break;
				case 7:
					label_type.Text = "Линейное уравнение\nИмеется единственный корень";
					break;
				case 8:
					label_type.Text = "Уравнение является прямой\nКорней бесконечное множество";
					break;
				case 9:
					label_type.Text = "Уравнение является прямой\nКорней нет";
					break;
			}
		}
	}
}

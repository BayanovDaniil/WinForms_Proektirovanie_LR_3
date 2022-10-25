namespace WinForms_Proektirovanie_LR_3
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_read_koef_from_file = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_a3 = new System.Windows.Forms.TextBox();
			this.tb_a2 = new System.Windows.Forms.TextBox();
			this.tb_a1 = new System.Windows.Forms.TextBox();
			this.tb_a0 = new System.Windows.Forms.TextBox();
			this.btn_save_koef_in_file = new System.Windows.Forms.Button();
			this.btn_draw_graphic = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_A = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_B = new System.Windows.Forms.TextBox();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_steps = new System.Windows.Forms.TextBox();
			this.btn_find_root = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_check_root = new System.Windows.Forms.Button();
			this.dgv_10 = new System.Windows.Forms.DataGridView();
			this.X1_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.X2_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.X3_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_14 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label_type = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_14)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(11, 11);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(539, 112);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btn_read_koef_from_file
			// 
			this.btn_read_koef_from_file.Location = new System.Drawing.Point(41, 127);
			this.btn_read_koef_from_file.Margin = new System.Windows.Forms.Padding(2);
			this.btn_read_koef_from_file.Name = "btn_read_koef_from_file";
			this.btn_read_koef_from_file.Size = new System.Drawing.Size(230, 30);
			this.btn_read_koef_from_file.TabIndex = 1;
			this.btn_read_koef_from_file.Text = "Считать коэффициенты из файла";
			this.btn_read_koef_from_file.UseVisualStyleBackColor = true;
			this.btn_read_koef_from_file.Click += new System.EventHandler(this.btn_read_koef_from_file_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(109, 170);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "а3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(216, 170);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "а2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(325, 170);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "а1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(434, 170);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "а0";
			// 
			// tb_a3
			// 
			this.tb_a3.Location = new System.Drawing.Point(64, 185);
			this.tb_a3.Margin = new System.Windows.Forms.Padding(2);
			this.tb_a3.Name = "tb_a3";
			this.tb_a3.Size = new System.Drawing.Size(102, 20);
			this.tb_a3.TabIndex = 6;
			// 
			// tb_a2
			// 
			this.tb_a2.Location = new System.Drawing.Point(172, 185);
			this.tb_a2.Margin = new System.Windows.Forms.Padding(2);
			this.tb_a2.Name = "tb_a2";
			this.tb_a2.Size = new System.Drawing.Size(102, 20);
			this.tb_a2.TabIndex = 7;
			// 
			// tb_a1
			// 
			this.tb_a1.Location = new System.Drawing.Point(280, 185);
			this.tb_a1.Margin = new System.Windows.Forms.Padding(2);
			this.tb_a1.Name = "tb_a1";
			this.tb_a1.Size = new System.Drawing.Size(102, 20);
			this.tb_a1.TabIndex = 8;
			// 
			// tb_a0
			// 
			this.tb_a0.Location = new System.Drawing.Point(387, 185);
			this.tb_a0.Margin = new System.Windows.Forms.Padding(2);
			this.tb_a0.Name = "tb_a0";
			this.tb_a0.Size = new System.Drawing.Size(102, 20);
			this.tb_a0.TabIndex = 9;
			// 
			// btn_save_koef_in_file
			// 
			this.btn_save_koef_in_file.Location = new System.Drawing.Point(290, 127);
			this.btn_save_koef_in_file.Margin = new System.Windows.Forms.Padding(2);
			this.btn_save_koef_in_file.Name = "btn_save_koef_in_file";
			this.btn_save_koef_in_file.Size = new System.Drawing.Size(230, 30);
			this.btn_save_koef_in_file.TabIndex = 10;
			this.btn_save_koef_in_file.Text = "Сохранить коэффициенты в файле";
			this.btn_save_koef_in_file.UseVisualStyleBackColor = true;
			this.btn_save_koef_in_file.Click += new System.EventHandler(this.btn_save_koef_in_file_Click);
			// 
			// btn_draw_graphic
			// 
			this.btn_draw_graphic.Location = new System.Drawing.Point(161, 213);
			this.btn_draw_graphic.Margin = new System.Windows.Forms.Padding(2);
			this.btn_draw_graphic.Name = "btn_draw_graphic";
			this.btn_draw_graphic.Size = new System.Drawing.Size(230, 30);
			this.btn_draw_graphic.TabIndex = 11;
			this.btn_draw_graphic.Text = "Построить график в диапазоне [A, B]";
			this.btn_draw_graphic.UseVisualStyleBackColor = true;
			this.btn_draw_graphic.Click += new System.EventHandler(this.btn_draw_graphic_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(144, 252);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "A =";
			// 
			// tb_A
			// 
			this.tb_A.Location = new System.Drawing.Point(168, 250);
			this.tb_A.Margin = new System.Windows.Forms.Padding(2);
			this.tb_A.Name = "tb_A";
			this.tb_A.Size = new System.Drawing.Size(95, 20);
			this.tb_A.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(287, 252);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "B =";
			// 
			// tb_B
			// 
			this.tb_B.Location = new System.Drawing.Point(311, 250);
			this.tb_B.Margin = new System.Windows.Forms.Padding(2);
			this.tb_B.Name = "tb_B";
			this.tb_B.Size = new System.Drawing.Size(95, 20);
			this.tb_B.TabIndex = 15;
			// 
			// chart
			// 
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(554, 11);
			this.chart.Margin = new System.Windows.Forms.Padding(2);
			this.chart.Name = "chart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart.Series.Add(series1);
			this.chart.Size = new System.Drawing.Size(844, 596);
			this.chart.TabIndex = 16;
			this.chart.Text = "chart1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(114, 279);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(142, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Число шагов локализации";
			// 
			// tb_steps
			// 
			this.tb_steps.Location = new System.Drawing.Point(253, 276);
			this.tb_steps.Margin = new System.Windows.Forms.Padding(2);
			this.tb_steps.Name = "tb_steps";
			this.tb_steps.Size = new System.Drawing.Size(95, 20);
			this.tb_steps.TabIndex = 18;
			// 
			// btn_find_root
			// 
			this.btn_find_root.Location = new System.Drawing.Point(161, 320);
			this.btn_find_root.Margin = new System.Windows.Forms.Padding(2);
			this.btn_find_root.Name = "btn_find_root";
			this.btn_find_root.Size = new System.Drawing.Size(230, 30);
			this.btn_find_root.TabIndex = 19;
			this.btn_find_root.Text = "Найти корни уравнения";
			this.btn_find_root.UseVisualStyleBackColor = true;
			this.btn_find_root.Click += new System.EventHandler(this.btn_find_root_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(148, 374);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(258, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Корни с точностью до 10-и знаков после запятой";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(148, 499);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(258, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Корни с точностью до 14-и знаков после запятой\r\n";
			// 
			// btn_check_root
			// 
			this.btn_check_root.Location = new System.Drawing.Point(161, 612);
			this.btn_check_root.Margin = new System.Windows.Forms.Padding(2);
			this.btn_check_root.Name = "btn_check_root";
			this.btn_check_root.Size = new System.Drawing.Size(230, 30);
			this.btn_check_root.TabIndex = 22;
			this.btn_check_root.Text = "Проверить корни уравнения";
			this.btn_check_root.UseVisualStyleBackColor = true;
			this.btn_check_root.Click += new System.EventHandler(this.btn_check_root_Click);
			// 
			// dgv_10
			// 
			this.dgv_10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1_Column,
            this.X2_Column,
            this.X3_Column});
			this.dgv_10.Location = new System.Drawing.Point(41, 389);
			this.dgv_10.Margin = new System.Windows.Forms.Padding(2);
			this.dgv_10.Name = "dgv_10";
			this.dgv_10.ReadOnly = true;
			this.dgv_10.RowHeadersWidth = 51;
			this.dgv_10.RowTemplate.Height = 24;
			this.dgv_10.Size = new System.Drawing.Size(469, 93);
			this.dgv_10.TabIndex = 23;
			// 
			// X1_Column
			// 
			this.X1_Column.HeaderText = "X1";
			this.X1_Column.MinimumWidth = 6;
			this.X1_Column.Name = "X1_Column";
			this.X1_Column.ReadOnly = true;
			this.X1_Column.Width = 125;
			// 
			// X2_Column
			// 
			this.X2_Column.HeaderText = "X2";
			this.X2_Column.MinimumWidth = 6;
			this.X2_Column.Name = "X2_Column";
			this.X2_Column.ReadOnly = true;
			this.X2_Column.Width = 125;
			// 
			// X3_Column
			// 
			this.X3_Column.HeaderText = "X3";
			this.X3_Column.MinimumWidth = 6;
			this.X3_Column.Name = "X3_Column";
			this.X3_Column.ReadOnly = true;
			this.X3_Column.Width = 125;
			// 
			// dgv_14
			// 
			this.dgv_14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_14.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dgv_14.Location = new System.Drawing.Point(41, 514);
			this.dgv_14.Margin = new System.Windows.Forms.Padding(2);
			this.dgv_14.Name = "dgv_14";
			this.dgv_14.ReadOnly = true;
			this.dgv_14.RowHeadersWidth = 51;
			this.dgv_14.RowTemplate.Height = 24;
			this.dgv_14.Size = new System.Drawing.Size(469, 93);
			this.dgv_14.TabIndex = 25;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "X1";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "X2";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "X3";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 125;
			// 
			// label_type
			// 
			this.label_type.AutoSize = true;
			this.label_type.Location = new System.Drawing.Point(551, 621);
			this.label_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_type.Name = "label_type";
			this.label_type.Size = new System.Drawing.Size(0, 13);
			this.label_type.TabIndex = 26;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1409, 656);
			this.Controls.Add(this.label_type);
			this.Controls.Add(this.dgv_14);
			this.Controls.Add(this.dgv_10);
			this.Controls.Add(this.btn_check_root);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btn_find_root);
			this.Controls.Add(this.tb_steps);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.tb_B);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_A);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn_draw_graphic);
			this.Controls.Add(this.btn_save_koef_in_file);
			this.Controls.Add(this.tb_a0);
			this.Controls.Add(this.tb_a1);
			this.Controls.Add(this.tb_a2);
			this.Controls.Add(this.tb_a3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_read_koef_from_file);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Проектирование ПО ЛР№3";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_14)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_read_koef_from_file;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_a3;
		private System.Windows.Forms.TextBox tb_a2;
		private System.Windows.Forms.TextBox tb_a1;
		private System.Windows.Forms.TextBox tb_a0;
		private System.Windows.Forms.Button btn_save_koef_in_file;
		private System.Windows.Forms.Button btn_draw_graphic;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_A;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_B;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_steps;
		private System.Windows.Forms.Button btn_find_root;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn_check_root;
		private System.Windows.Forms.DataGridView dgv_10;
		private System.Windows.Forms.DataGridViewTextBoxColumn X1_Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn X2_Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn X3_Column;
		private System.Windows.Forms.DataGridView dgv_14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Label label_type;
	}
}


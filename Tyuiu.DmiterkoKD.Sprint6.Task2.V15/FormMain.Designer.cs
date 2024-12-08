namespace Tyuiu.DmiterkoKD.Sprint6.Task2.V15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxY_DKD = new TextBox();
            textBoxYY_DKD = new TextBox();
            textBoxV_DKD = new TextBox();
            textBoxV1_DKD = new TextBox();
            textBoxV2_DKD = new TextBox();
            textBoxX1_DKD = new TextBox();
            textBoxX2_DKD = new TextBox();
            textBox_DKD = new TextBox();
            dataGridView1 = new DataGridView();
            Column = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            chartFun = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDun_DKD = new Button();
            Help_DKD = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFun).BeginInit();
            SuspendLayout();
            // 
            // textBoxY_DKD
            // 
            textBoxY_DKD.Location = new Point(0, 0);
            textBoxY_DKD.Multiline = true;
            textBoxY_DKD.Name = "textBoxY_DKD";
            textBoxY_DKD.ReadOnly = true;
            textBoxY_DKD.Size = new Size(371, 221);
            textBoxY_DKD.TabIndex = 0;
            textBoxY_DKD.Text = "Условие";
            // 
            // textBoxYY_DKD
            // 
            textBoxYY_DKD.Location = new Point(12, 24);
            textBoxYY_DKD.Multiline = true;
            textBoxYY_DKD.Name = "textBoxYY_DKD";
            textBoxYY_DKD.ReadOnly = true;
            textBoxYY_DKD.Size = new Size(342, 181);
            textBoxYY_DKD.TabIndex = 1;
            textBoxYY_DKD.Text = "Протабулировать функцию на заданном интервале. Результат вывести в DataGndView и посторить график функции.";
            // 
            // textBoxV_DKD
            // 
            textBoxV_DKD.Location = new Point(0, 227);
            textBoxV_DKD.Multiline = true;
            textBoxV_DKD.Name = "textBoxV_DKD";
            textBoxV_DKD.ReadOnly = true;
            textBoxV_DKD.Size = new Size(371, 211);
            textBoxV_DKD.TabIndex = 2;
            textBoxV_DKD.Text = "Ввод данных";
            // 
            // textBoxV1_DKD
            // 
            textBoxV1_DKD.Location = new Point(0, 256);
            textBoxV1_DKD.Multiline = true;
            textBoxV1_DKD.Name = "textBoxV1_DKD";
            textBoxV1_DKD.ReadOnly = true;
            textBoxV1_DKD.Size = new Size(137, 95);
            textBoxV1_DKD.TabIndex = 3;
            textBoxV1_DKD.Text = "Старт шага";
            // 
            // textBoxV2_DKD
            // 
            textBoxV2_DKD.Location = new Point(179, 256);
            textBoxV2_DKD.Multiline = true;
            textBoxV2_DKD.Name = "textBoxV2_DKD";
            textBoxV2_DKD.ReadOnly = true;
            textBoxV2_DKD.Size = new Size(148, 95);
            textBoxV2_DKD.TabIndex = 4;
            textBoxV2_DKD.Text = "Конец шага";
            // 
            // textBoxX1_DKD
            // 
            textBoxX1_DKD.Location = new Point(12, 298);
            textBoxX1_DKD.Name = "textBoxX1_DKD";
            textBoxX1_DKD.Size = new Size(100, 23);
            textBoxX1_DKD.TabIndex = 5;
            // 
            // textBoxX2_DKD
            // 
            textBoxX2_DKD.Location = new Point(203, 298);
            textBoxX2_DKD.Name = "textBoxX2_DKD";
            textBoxX2_DKD.Size = new Size(100, 23);
            textBoxX2_DKD.TabIndex = 6;
            // 
            // textBox_DKD
            // 
            textBox_DKD.Location = new Point(388, 0);
            textBox_DKD.Multiline = true;
            textBox_DKD.Name = "textBox_DKD";
            textBox_DKD.ReadOnly = true;
            textBox_DKD.Size = new Size(537, 438);
            textBox_DKD.TabIndex = 7;
            textBox_DKD.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column, Column1 });
            dataGridView1.Location = new Point(402, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(208, 359);
            dataGridView1.TabIndex = 8;
            // 
            // Column
            // 
            Column.HeaderText = "X";
            Column.Name = "Column";
            // 
            // Column1
            // 
            Column1.HeaderText = "F(X)";
            Column1.Name = "Column1";
            // 
            // chartFun
            // 
            chartArea1.Name = "ChartArea1";
            chartFun.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFun.Legends.Add(legend1);
            chartFun.Location = new Point(625, 35);
            chartFun.Name = "chartFun";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFun.Series.Add(series1);
            chartFun.Size = new Size(300, 300);
            chartFun.TabIndex = 9;
            chartFun.Text = "chart1";
            // 
            // buttonDun_DKD
            // 
            buttonDun_DKD.BackColor = Color.IndianRed;
            buttonDun_DKD.Location = new Point(244, 382);
            buttonDun_DKD.Name = "buttonDun_DKD";
            buttonDun_DKD.Size = new Size(110, 43);
            buttonDun_DKD.TabIndex = 12;
            buttonDun_DKD.Text = "Выполнить";
            buttonDun_DKD.UseVisualStyleBackColor = false;
            buttonDun_DKD.Click += buttonDone_Click;
            buttonDun_DKD.MouseEnter += buttonDone_MouseEnter;
            buttonDun_DKD.MouseLeave += buttonDone_MouseLeave;
            // 
            // Help_DKD
            // 
            Help_DKD.BackColor = Color.GreenYellow;
            Help_DKD.Location = new Point(179, 382);
            Help_DKD.Name = "Help_DKD";
            Help_DKD.Size = new Size(49, 43);
            Help_DKD.TabIndex = 13;
            Help_DKD.Text = "?";
            Help_DKD.UseVisualStyleBackColor = false;
            Help_DKD.Click += buttonHelp;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 450);
            Controls.Add(Help_DKD);
            Controls.Add(buttonDun_DKD);
            Controls.Add(chartFun);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_DKD);
            Controls.Add(textBoxX2_DKD);
            Controls.Add(textBoxX1_DKD);
            Controls.Add(textBoxV2_DKD);
            Controls.Add(textBoxV1_DKD);
            Controls.Add(textBoxV_DKD);
            Controls.Add(textBoxYY_DKD);
            Controls.Add(textBoxY_DKD);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 15 | Дмитерко К.Д.";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxY_DKD;
        private TextBox textBoxYY_DKD;
        private TextBox textBoxV_DKD;
        private TextBox textBoxV1_DKD;
        private TextBox textBoxV2_DKD;
        private TextBox textBoxX1_DKD;
        private TextBox textBoxX2_DKD;
        private TextBox textBox_DKD;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFun;
        private Button buttonDun_DKD;
        private Button Help_DKD;
    }
}

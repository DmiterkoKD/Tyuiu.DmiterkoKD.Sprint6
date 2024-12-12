namespace Tyuiu.DmiterkoKD.Sprint6.Task5.V13
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
            chartFun_DKD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_DKD = new DataGridView();
            Help_DKD = new Button();
            Go_DKD = new Button();
            Save_DKD = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chartFun_DKD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DKD).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chartFun_DKD
            // 
            chartArea1.Name = "ChartArea1";
            chartFun_DKD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFun_DKD.Legends.Add(legend1);
            chartFun_DKD.Location = new Point(73, 26);
            chartFun_DKD.Name = "chartFun_DKD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFun_DKD.Series.Add(series1);
            chartFun_DKD.Size = new Size(583, 486);
            chartFun_DKD.TabIndex = 0;
            chartFun_DKD.Text = "chart1";
            // 
            // dataGridView_DKD
            // 
            dataGridView_DKD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DKD.ColumnHeadersVisible = false;
            dataGridView_DKD.Location = new Point(6, 33);
            dataGridView_DKD.Name = "dataGridView_DKD";
            dataGridView_DKD.RowHeadersVisible = false;
            dataGridView_DKD.Size = new Size(240, 489);
            dataGridView_DKD.TabIndex = 1;
            // 
            // Help_DKD
            // 
            Help_DKD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Help_DKD.BackColor = Color.FromArgb(255, 128, 128);
            Help_DKD.Location = new Point(922, 20);
            Help_DKD.Name = "Help_DKD";
            Help_DKD.Size = new Size(60, 60);
            Help_DKD.TabIndex = 2;
            Help_DKD.Text = "?";
            Help_DKD.UseVisualStyleBackColor = false;
            Help_DKD.Click += buttonHelp;
            // 
            // Go_DKD
            // 
            Go_DKD.BackColor = SystemColors.ActiveCaption;
            Go_DKD.Location = new Point(514, 22);
            Go_DKD.Name = "Go_DKD";
            Go_DKD.Size = new Size(125, 60);
            Go_DKD.TabIndex = 3;
            Go_DKD.Text = "Выполнить";
            Go_DKD.UseVisualStyleBackColor = false;
            Go_DKD.Click += buttonDone_Click;
            // 
            // Save_DKD
            // 
            Save_DKD.BackColor = Color.Lime;
            Save_DKD.Location = new Point(659, 20);
            Save_DKD.Name = "Save_DKD";
            Save_DKD.Size = new Size(125, 60);
            Save_DKD.TabIndex = 4;
            Save_DKD.Text = "Открыть";
            Save_DKD.UseVisualStyleBackColor = false;
            Save_DKD.Click += buttonOpen_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(Save_DKD);
            panel1.Controls.Add(Go_DKD);
            panel1.Controls.Add(Help_DKD);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 100);
            panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(427, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V13.txt. Вывести в dataGridBoxView значения меньше 10 и построить диаграмму по этим значениям";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 540);
            panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView_DKD);
            groupBox2.Location = new Point(3, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 506);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // panel3
            // 
            panel3.Controls.Add(chartFun_DKD);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(264, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(755, 540);
            panel3.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 640);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartFun_DKD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DKD).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFun_DKD;
        private DataGridView dataGridView_DKD;
        private Button Help_DKD;
        private Button Go_DKD;
        private Button Save_DKD;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Panel panel3;
        private TextBox textBox1;
    }
}

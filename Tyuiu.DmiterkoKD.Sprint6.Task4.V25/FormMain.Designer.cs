namespace Tyuiu.DmiterkoKD.Sprint6.Task4.V25
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
            Start_DKD = new TextBox();
            End_DKD = new TextBox();
            chartFun_DKD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Result_DKD = new TextBox();
            panel1 = new Panel();
            ButtonClikc_DKD = new Button();
            Save_DKD = new Button();
            Help_DKD = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox_DKD = new GroupBox();
            textBoxY_DKD = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)chartFun_DKD).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox_DKD.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Start_DKD
            // 
            Start_DKD.Location = new Point(6, 35);
            Start_DKD.Multiline = true;
            Start_DKD.Name = "Start_DKD";
            Start_DKD.Size = new Size(121, 31);
            Start_DKD.TabIndex = 0;
            // 
            // End_DKD
            // 
            End_DKD.Location = new Point(6, 35);
            End_DKD.Multiline = true;
            End_DKD.Name = "End_DKD";
            End_DKD.Size = new Size(121, 31);
            End_DKD.TabIndex = 1;
            // 
            // chartFun_DKD
            // 
            chartArea1.Name = "ChartArea1";
            chartFun_DKD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFun_DKD.Legends.Add(legend1);
            chartFun_DKD.Location = new Point(507, 156);
            chartFun_DKD.Name = "chartFun_DKD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFun_DKD.Series.Add(series1);
            chartFun_DKD.Size = new Size(514, 419);
            chartFun_DKD.TabIndex = 2;
            chartFun_DKD.Text = "chart1";
            chartFun_DKD.Click += chartFun_DKD_Click;
            // 
            // Result_DKD
            // 
            Result_DKD.Location = new Point(9, 39);
            Result_DKD.Multiline = true;
            Result_DKD.Name = "Result_DKD";
            Result_DKD.Size = new Size(353, 323);
            Result_DKD.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(ButtonClikc_DKD);
            panel1.Controls.Add(Save_DKD);
            panel1.Controls.Add(Help_DKD);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox_DKD);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 100);
            panel1.TabIndex = 4;
            // 
            // ButtonClikc_DKD
            // 
            ButtonClikc_DKD.BackColor = SystemColors.ActiveCaption;
            ButtonClikc_DKD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonClikc_DKD.ForeColor = SystemColors.ActiveCaptionText;
            ButtonClikc_DKD.Location = new Point(781, 22);
            ButtonClikc_DKD.Name = "ButtonClikc_DKD";
            ButtonClikc_DKD.Size = new Size(88, 60);
            ButtonClikc_DKD.TabIndex = 7;
            ButtonClikc_DKD.Text = " Выполнить";
            ButtonClikc_DKD.UseVisualStyleBackColor = false;
            ButtonClikc_DKD.Click += buttonDone_Click;
            // 
            // Save_DKD
            // 
            Save_DKD.BackColor = Color.OliveDrab;
            Save_DKD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Save_DKD.ForeColor = SystemColors.ActiveCaptionText;
            Save_DKD.Location = new Point(884, 22);
            Save_DKD.Name = "Save_DKD";
            Save_DKD.Size = new Size(94, 60);
            Save_DKD.TabIndex = 6;
            Save_DKD.Text = "Сохранить";
            Save_DKD.UseVisualStyleBackColor = false;
            Save_DKD.Click += buttonSave_Click;
            // 
            // Help_DKD
            // 
            Help_DKD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Help_DKD.BackColor = Color.IndianRed;
            Help_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Help_DKD.ForeColor = SystemColors.ActiveCaptionText;
            Help_DKD.Location = new Point(1050, 22);
            Help_DKD.Name = "Help_DKD";
            Help_DKD.Size = new Size(60, 60);
            Help_DKD.TabIndex = 2;
            Help_DKD.Text = "?";
            Help_DKD.UseVisualStyleBackColor = false;
            Help_DKD.Click += buttonHelp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(425, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(End_DKD);
            groupBox3.Location = new Point(161, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(150, 72);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Конец шага";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Start_DKD);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 72);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Старт шага";
            // 
            // groupBox_DKD
            // 
            groupBox_DKD.Controls.Add(textBoxY_DKD);
            groupBox_DKD.Location = new Point(0, 0);
            groupBox_DKD.Name = "groupBox_DKD";
            groupBox_DKD.Size = new Size(419, 100);
            groupBox_DKD.TabIndex = 2;
            groupBox_DKD.TabStop = false;
            groupBox_DKD.Text = "Условие";
            // 
            // textBoxY_DKD
            // 
            textBoxY_DKD.Location = new Point(3, 19);
            textBoxY_DKD.Multiline = true;
            textBoxY_DKD.Name = "textBoxY_DKD";
            textBoxY_DKD.ReadOnly = true;
            textBoxY_DKD.Size = new Size(398, 69);
            textBoxY_DKD.TabIndex = 0;
            textBoxY_DKD.Text = "Протабулировать функцию на заданом интервалею. \r\nРезультат вывести в textbox, построть график функции и сохранить в файл OutPutTask4.txt по нажатию кнопки";
            // 
            // panel3
            // 
            panel3.Controls.Add(chartFun_DKD);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1124, 615);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 615);
            panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Result_DKD);
            groupBox4.Location = new Point(3, 106);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(398, 446);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Вывод";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1124, 615);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 25 | Дмитерко К.Д.";
            ((System.ComponentModel.ISupportInitialize)chartFun_DKD).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox_DKD.ResumeLayout(false);
            groupBox_DKD.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Start_DKD;
        private TextBox End_DKD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFun_DKD;
        private TextBox Result_DKD;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox_DKD;
        private TextBox textBoxY_DKD;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button ButtonClikc_DKD;
        private Button Save_DKD;
        private Button Help_DKD;
        private GroupBox groupBox4;
    }
}

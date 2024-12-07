namespace Tyuiu.DmiterkoKD.Sprint6.Task1.V29
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
            textBoxY_DKD = new TextBox();
            textBoxYY_DKD = new TextBox();
            textBoxV_DKD = new TextBox();
            textBoxstart_DKD = new TextBox();
            textBoxend_DKD = new TextBox();
            textBoxK_DKD = new TextBox();
            textBoxX_DKD = new TextBox();
            textBoxX2_DKD = new TextBox();
            textBoxI_DKD = new TextBox();
            I_DKD = new TextBox();
            SuspendLayout();
            // 
            // textBoxY_DKD
            // 
            textBoxY_DKD.Location = new Point(0, 0);
            textBoxY_DKD.Multiline = true;
            textBoxY_DKD.Name = "textBoxY_DKD";
            textBoxY_DKD.ReadOnly = true;
            textBoxY_DKD.Size = new Size(435, 237);
            textBoxY_DKD.TabIndex = 0;
            textBoxY_DKD.Text = "Условие:";
            // 
            // textBoxYY_DKD
            // 
            textBoxYY_DKD.Location = new Point(12, 27);
            textBoxYY_DKD.Multiline = true;
            textBoxYY_DKD.Name = "textBoxYY_DKD";
            textBoxYY_DKD.ReadOnly = true;
            textBoxYY_DKD.Size = new Size(290, 63);
            textBoxYY_DKD.TabIndex = 1;
            textBoxYY_DKD.Text = "Продабулировать функцию cos(x) на заданном диапазоне. Результат вывессти в виде таблице.";
            // 
            // textBoxV_DKD
            // 
            textBoxV_DKD.Location = new Point(12, 292);
            textBoxV_DKD.Multiline = true;
            textBoxV_DKD.Name = "textBoxV_DKD";
            textBoxV_DKD.ReadOnly = true;
            textBoxV_DKD.Size = new Size(339, 146);
            textBoxV_DKD.TabIndex = 2;
            textBoxV_DKD.Text = "Ввод данных:";
            // 
            // textBoxstart_DKD
            // 
            textBoxstart_DKD.Location = new Point(12, 324);
            textBoxstart_DKD.Multiline = true;
            textBoxstart_DKD.Name = "textBoxstart_DKD";
            textBoxstart_DKD.ReadOnly = true;
            textBoxstart_DKD.Size = new Size(159, 97);
            textBoxstart_DKD.TabIndex = 3;
            textBoxstart_DKD.Text = "Старт шага:";
            // 
            // textBoxend_DKD
            // 
            textBoxend_DKD.Location = new Point(177, 324);
            textBoxend_DKD.Multiline = true;
            textBoxend_DKD.Name = "textBoxend_DKD";
            textBoxend_DKD.ReadOnly = true;
            textBoxend_DKD.Size = new Size(159, 97);
            textBoxend_DKD.TabIndex = 4;
            textBoxend_DKD.Text = "Конец шага:";
            // 
            // textBoxK_DKD
            // 
            textBoxK_DKD.BackColor = SystemColors.ActiveCaption;
            textBoxK_DKD.Location = new Point(367, 399);
            textBoxK_DKD.Multiline = true;
            textBoxK_DKD.Name = "textBoxK_DKD";
            textBoxK_DKD.ReadOnly = true;
            textBoxK_DKD.Size = new Size(100, 39);
            textBoxK_DKD.TabIndex = 5;
            textBoxK_DKD.Text = "Выполнить:";
            textBoxK_DKD.MouseEnter += buttonDone_Click;
            // 
            // textBoxX_DKD
            // 
            textBoxX_DKD.Location = new Point(30, 371);
            textBoxX_DKD.Name = "textBoxX_DKD";
            textBoxX_DKD.Size = new Size(100, 23);
            textBoxX_DKD.TabIndex = 6;
            // 
            // textBoxX2_DKD
            // 
            textBoxX2_DKD.Location = new Point(202, 371);
            textBoxX2_DKD.Name = "textBoxX2_DKD";
            textBoxX2_DKD.Size = new Size(100, 23);
            textBoxX2_DKD.TabIndex = 7;
            // 
            // textBoxI_DKD
            // 
            textBoxI_DKD.Location = new Point(473, 0);
            textBoxI_DKD.Multiline = true;
            textBoxI_DKD.Name = "textBoxI_DKD";
            textBoxI_DKD.ReadOnly = true;
            textBoxI_DKD.Size = new Size(323, 438);
            textBoxI_DKD.TabIndex = 8;
            textBoxI_DKD.Text = "Вывод данных:";
            // 
            // I_DKD
            // 
            I_DKD.Location = new Point(486, 27);
            I_DKD.Multiline = true;
            I_DKD.Name = "I_DKD";
            I_DKD.Size = new Size(288, 384);
            I_DKD.TabIndex = 9;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(I_DKD);
            Controls.Add(textBoxI_DKD);
            Controls.Add(textBoxX2_DKD);
            Controls.Add(textBoxX_DKD);
            Controls.Add(textBoxK_DKD);
            Controls.Add(textBoxend_DKD);
            Controls.Add(textBoxstart_DKD);
            Controls.Add(textBoxV_DKD);
            Controls.Add(textBoxYY_DKD);
            Controls.Add(textBoxY_DKD);
            Name = "FormMain";
            Text = "Спринт 6 | Таск1 | Вариант 29 | Дмитерко К.Д.";
            KeyPress += textBoxVarXC_ReyPress;
            MouseEnter += buttonDone_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxY_DKD;
        private TextBox textBoxYY_DKD;
        private TextBox textBoxV_DKD;
        private TextBox textBoxstart_DKD;
        private TextBox textBoxend_DKD;
        private TextBox textBoxK_DKD;
        private TextBox textBoxX_DKD;
        private TextBox textBoxX2_DKD;
        private TextBox textBoxI_DKD;
        private TextBox I_DKD;
    }
}

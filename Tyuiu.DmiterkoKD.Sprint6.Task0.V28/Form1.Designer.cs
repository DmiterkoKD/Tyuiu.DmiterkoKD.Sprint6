namespace Tyuiu.DmiterkoKD.Sprint6.Task0.V28
{
    partial class Form1
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
            textBoxI_DKD = new TextBox();
            textBoxV_DKD = new TextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBoxY_DKD = new TextBox();
            textBoxVV_DKD = new TextBox();
            textBoxX_DKD = new TextBox();
            textBoxResult_DKD = new TextBox();
            textBoxRes_DKD = new TextBox();
            textBoxXX_DKD = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxI_DKD
            // 
            textBoxI_DKD.BackColor = SystemColors.InactiveCaption;
            textBoxI_DKD.Location = new Point(577, 415);
            textBoxI_DKD.Name = "textBoxI_DKD";
            textBoxI_DKD.Size = new Size(168, 23);
            textBoxI_DKD.TabIndex = 11;
            textBoxI_DKD.Text = "Выполнить";
            textBoxI_DKD.Enter += button_Click;
            textBoxI_DKD.KeyPress += textBoxVarXC_ReyPress;
            // 
            // textBoxV_DKD
            // 
            textBoxV_DKD.Location = new Point(12, 249);
            textBoxV_DKD.Multiline = true;
            textBoxV_DKD.Name = "textBoxV_DKD";
            textBoxV_DKD.ReadOnly = true;
            textBoxV_DKD.Size = new Size(341, 141);
            textBoxV_DKD.TabIndex = 0;
            textBoxV_DKD.Text = "Ввод Данных";
            textBoxV_DKD.KeyPress += textBoxVarXC_ReyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(200, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(12, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(341, 200);
            textBox1.TabIndex = 3;
            textBox1.Text = "Вычислить выражение по формуле";
            // 
            // textBoxY_DKD
            // 
            textBoxY_DKD.Cursor = Cursors.IBeam;
            textBoxY_DKD.ForeColor = SystemColors.MenuText;
            textBoxY_DKD.Location = new Point(12, 12);
            textBoxY_DKD.Multiline = true;
            textBoxY_DKD.Name = "textBoxY_DKD";
            textBoxY_DKD.ReadOnly = true;
            textBoxY_DKD.Size = new Size(100, 23);
            textBoxY_DKD.TabIndex = 4;
            textBoxY_DKD.Text = "Условие";
            // 
            // textBoxVV_DKD
            // 
            textBoxVV_DKD.Location = new Point(397, 249);
            textBoxVV_DKD.Multiline = true;
            textBoxVV_DKD.Name = "textBoxVV_DKD";
            textBoxVV_DKD.ReadOnly = true;
            textBoxVV_DKD.Size = new Size(341, 141);
            textBoxVV_DKD.TabIndex = 5;
            textBoxVV_DKD.Text = "Вывод Данных";
            // 
            // textBoxX_DKD
            // 
            textBoxX_DKD.Location = new Point(129, 303);
            textBoxX_DKD.Name = "textBoxX_DKD";
            textBoxX_DKD.ReadOnly = true;
            textBoxX_DKD.Size = new Size(100, 23);
            textBoxX_DKD.TabIndex = 6;
            textBoxX_DKD.Text = "Переменная Х:";
            textBoxX_DKD.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResult_DKD
            // 
            textBoxResult_DKD.Location = new Point(528, 303);
            textBoxResult_DKD.Name = "textBoxResult_DKD";
            textBoxResult_DKD.ReadOnly = true;
            textBoxResult_DKD.Size = new Size(100, 23);
            textBoxResult_DKD.TabIndex = 7;
            textBoxResult_DKD.Text = "Результат:";
            textBoxResult_DKD.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRes_DKD
            // 
            textBoxRes_DKD.Location = new Point(510, 356);
            textBoxRes_DKD.Name = "textBoxRes_DKD";
            textBoxRes_DKD.ReadOnly = true;
            textBoxRes_DKD.Size = new Size(137, 23);
            textBoxRes_DKD.TabIndex = 9;
            textBoxRes_DKD.Enter += button_Click;
            textBoxRes_DKD.KeyPress += textBoxVarXC_ReyPress;
            textBoxRes_DKD.MouseEnter += textBox1_TextChanged_1;
            // 
            // textBoxXX_DKD
            // 
            textBoxXX_DKD.Location = new Point(129, 356);
            textBoxXX_DKD.Name = "textBoxXX_DKD";
            textBoxXX_DKD.Size = new Size(100, 23);
            textBoxXX_DKD.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(434, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxI_DKD);
            Controls.Add(textBoxXX_DKD);
            Controls.Add(textBoxRes_DKD);
            Controls.Add(textBoxResult_DKD);
            Controls.Add(textBoxX_DKD);
            Controls.Add(textBoxVV_DKD);
            Controls.Add(textBoxY_DKD);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxV_DKD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 0 | Вариант 28 | Дмитерко К.Д,";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxV_DKD;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBoxY_DKD;
        private TextBox textBoxVV_DKD;
        private TextBox textBoxX_DKD;
        private TextBox textBoxResult_DKD;
        private TextBox textBoxRes_DKD;
        private TextBox textBoxXX_DKD;
        private TextBox textBoxI_DKD;
        private PictureBox pictureBox2;
    }
}

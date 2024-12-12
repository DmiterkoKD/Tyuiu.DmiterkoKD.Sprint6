namespace Tyuiu.DmiterkoKD.Sprint6.Task6.V10
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
            components = new System.ComponentModel.Container();
            Res_DKD = new TextBox();
            openFileDialogTask_DKD = new OpenFileDialog();
            toolTip_DKD = new ToolTip(components);
            Go_DKD = new Button();
            In_DKD = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Res_DKD
            // 
            Res_DKD.Location = new Point(434, 176);
            Res_DKD.Multiline = true;
            Res_DKD.Name = "Res_DKD";
            Res_DKD.Size = new Size(276, 262);
            Res_DKD.TabIndex = 0;
            // 
            // openFileDialogTask_DKD
            // 
            openFileDialogTask_DKD.FileName = "openFileDialogTask_DKD";
            // 
            // Go_DKD
            // 
            Go_DKD.Location = new Point(208, 35);
            Go_DKD.Name = "Go_DKD";
            Go_DKD.Size = new Size(75, 23);
            Go_DKD.TabIndex = 1;
            Go_DKD.Text = "Go_DKD";
            Go_DKD.UseVisualStyleBackColor = true;
            Go_DKD.Click += buttonDone_Click;
            // 
            // In_DKD
            // 
            In_DKD.Location = new Point(158, 202);
            In_DKD.Multiline = true;
            In_DKD.Name = "In_DKD";
            In_DKD.Size = new Size(212, 210);
            In_DKD.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(361, 51);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonOpenFile_ISI_Click;
            // 
            // button2
            // 
            button2.Location = new Point(531, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonHelp_ISI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(In_DKD);
            Controls.Add(Go_DKD);
            Controls.Add(Res_DKD);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Res_DKD;
        private OpenFileDialog openFileDialogTask_DKD;
        private ToolTip toolTip_DKD;
        private Button Go_DKD;
        private TextBox In_DKD;
        private Button button1;
        private Button button2;
    }
}

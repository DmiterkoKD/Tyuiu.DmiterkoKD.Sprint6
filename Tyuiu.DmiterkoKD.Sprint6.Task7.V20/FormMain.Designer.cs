namespace Tyuiu.DmiterkoKD.Sprint6.Task7.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            Open_DKD = new Button();
            Save_DKD = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            dataIn_DKD = new DataGridView();
            dataOut_DKD = new DataGridView();
            buttonDune_DKD = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataIn_DKD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataOut_DKD).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Open_DKD
            // 
            Open_DKD.BackColor = SystemColors.ActiveCaption;
            Open_DKD.Location = new Point(11, 9);
            Open_DKD.Name = "Open_DKD";
            Open_DKD.Size = new Size(130, 60);
            Open_DKD.TabIndex = 0;
            Open_DKD.Text = "Открыть";
            Open_DKD.UseVisualStyleBackColor = false;
            Open_DKD.Click += buttonOpenFile_Click;
            // 
            // Save_DKD
            // 
            Save_DKD.BackColor = Color.FromArgb(192, 255, 192);
            Save_DKD.Location = new Point(283, 12);
            Save_DKD.Name = "Save_DKD";
            Save_DKD.Size = new Size(130, 60);
            Save_DKD.TabIndex = 1;
            Save_DKD.Text = "Сохранить";
            Save_DKD.UseVisualStyleBackColor = false;
            Save_DKD.Click += buttonsave;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataIn_DKD
            // 
            dataIn_DKD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataIn_DKD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataIn_DKD.ColumnHeadersVisible = false;
            dataIn_DKD.Location = new Point(3, 189);
            dataIn_DKD.Name = "dataIn_DKD";
            dataIn_DKD.RowHeadersVisible = false;
            dataIn_DKD.Size = new Size(401, 327);
            dataIn_DKD.TabIndex = 2;
            // 
            // dataOut_DKD
            // 
            dataOut_DKD.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataOut_DKD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataOut_DKD.ColumnHeadersVisible = false;
            dataOut_DKD.Location = new Point(425, 189);
            dataOut_DKD.Name = "dataOut_DKD";
            dataOut_DKD.RowHeadersVisible = false;
            dataOut_DKD.Size = new Size(363, 327);
            dataOut_DKD.TabIndex = 3;
            // 
            // buttonDune_DKD
            // 
            buttonDune_DKD.BackColor = Color.FromArgb(255, 255, 128);
            buttonDune_DKD.Location = new Point(147, 12);
            buttonDune_DKD.Name = "buttonDune_DKD";
            buttonDune_DKD.Size = new Size(130, 60);
            buttonDune_DKD.TabIndex = 5;
            buttonDune_DKD.Text = "Выполнить";
            buttonDune_DKD.UseVisualStyleBackColor = false;
            buttonDune_DKD.Click += buttonDone_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Open_DKD);
            panel1.Controls.Add(buttonDune_DKD);
            panel1.Controls.Add(Save_DKD);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 75);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(658, 9);
            button1.Name = "button1";
            button1.Size = new Size(130, 60);
            button1.TabIndex = 7;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonHelp_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 83);
            panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(785, 61);
            textBox1.TabIndex = 8;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataOut_DKD);
            Controls.Add(dataIn_DKD);
            MinimumSize = new Size(816, 567);
            Name = "FormMain";
            Text = "Дмитерко К.Д. | Спринт6 | Таск 7 | Вариант20";
            ((System.ComponentModel.ISupportInitialize)dataIn_DKD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataOut_DKD).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Open_DKD;
        private Button Save_DKD;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolTip toolTip1;
        private DataGridView dataIn_DKD;
        private DataGridView dataOut_DKD;
        private Button buttonDune_DKD;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}

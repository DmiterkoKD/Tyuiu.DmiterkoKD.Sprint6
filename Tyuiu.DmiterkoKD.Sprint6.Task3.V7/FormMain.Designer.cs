namespace Tyuiu.DmiterkoKD.Sprint6.Task3.V7
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
            textBoxY_DKD = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxY1_DKD = new TextBox();
            dataGridView_DKD = new DataGridView();
            Colums1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBoxRes_DKD = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DKD).BeginInit();
            SuspendLayout();
            // 
            // textBoxY_DKD
            // 
            textBoxY_DKD.Location = new Point(12, 12);
            textBoxY_DKD.Multiline = true;
            textBoxY_DKD.Name = "textBoxY_DKD";
            textBoxY_DKD.ReadOnly = true;
            textBoxY_DKD.Size = new Size(294, 232);
            textBoxY_DKD.TabIndex = 0;
            textBoxY_DKD.Text = "Условие";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxY1_DKD
            // 
            textBoxY1_DKD.ForeColor = SystemColors.InactiveCaption;
            textBoxY1_DKD.Location = new Point(12, 38);
            textBoxY1_DKD.Multiline = true;
            textBoxY1_DKD.Name = "textBoxY1_DKD";
            textBoxY1_DKD.ReadOnly = true;
            textBoxY1_DKD.Size = new Size(217, 184);
            textBoxY1_DKD.TabIndex = 2;
            textBoxY1_DKD.Text = resources.GetString("textBoxY1_DKD.Text");
            // 
            // dataGridView_DKD
            // 
            dataGridView_DKD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DKD.ColumnHeadersVisible = false;
            dataGridView_DKD.Columns.AddRange(new DataGridViewColumn[] { Colums1, Column1, Column2, Column3, Column4 });
            dataGridView_DKD.Location = new Point(12, 228);
            dataGridView_DKD.Name = "dataGridView_DKD";
            dataGridView_DKD.RowHeadersVisible = false;
            dataGridView_DKD.Size = new Size(251, 232);
            dataGridView_DKD.TabIndex = 4;
            // 
            // Colums1
            // 
            Colums1.HeaderText = "Column1";
            Colums1.Name = "Colums1";
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(446, 416);
            textBox1.TabIndex = 6;
            textBox1.Text = "Вывод данных:";
            // 
            // textBoxRes_DKD
            // 
            textBoxRes_DKD.Location = new Point(360, 74);
            textBoxRes_DKD.Name = "textBoxRes_DKD";
            textBoxRes_DKD.Size = new Size(363, 23);
            textBoxRes_DKD.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Location = new Point(391, 290);
            button1.Name = "button1";
            button1.Size = new Size(278, 120);
            button1.TabIndex = 8;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxRes_DKD);
            Controls.Add(dataGridView_DKD);
            Controls.Add(textBoxY1_DKD);
            Controls.Add(textBoxY_DKD);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 7 | Дмитерко К.Д.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_DKD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxY_DKD;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxY1_DKD;
        private DataGridView dataGridView_DKD;
        private TextBox textBox1;
        private TextBox textBoxRes_DKD;
        private Button button1;
        private DataGridViewTextBoxColumn Colums1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}

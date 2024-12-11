using Tyuiu.DmiterkoKD.Sprint6.Task3.V7.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mrtx = new int[5, 5] { { 31, 25, -18, 12, 9 },
                                      { 6, 34, -2, 2, -18 },
                                      { -5, 4, 27, 4, -1 },
                                      { 4, 15, 34, -6, -10 },
                                      { 0, 8, 5, 14, -17 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mrtx.GetUpperBound(0) + 1;
            int columns = mrtx.Length / rows;

            dataGridView_DKD.ColumnCount = columns;
            dataGridView_DKD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_DKD.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_DKD.Rows[i].Cells[j].Value = Convert.ToString(mrtx[i, j]);
                }
            }
        }

        private void textBoxMatrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 3 âûïîëíèë ñòóäåíò ãðóïïû ÏÊÒá-24-1 Îñàäåö Àëåêñàíäð Àëåêñàíäðîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] martx = ds.Calculate(mrtx);
            for (int i = 0; i < martx.GetLength(0); i++)
            {
                for (int j = 0; j < martx.GetLength(1); j++)
                {
                    textBoxRes_DKD.AppendText(Convert.ToString(martx[i, j]) + "   ");
                }
                textBoxRes_DKD.AppendText(Environment.NewLine);
            }
        }
    }
}

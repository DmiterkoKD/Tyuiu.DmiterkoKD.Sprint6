using Tyuiu.DmiterkoKD.Sprint6.Task7.V20.Lib;
using System.IO;
namespace Tyuiu.DmiterkoKD.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arr = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arr[r,c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arr;
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            int[,] arr= new int[rows, cols];
            arr = LoadFromFileData(openFilePath);

            dataIn_DKD.ColumnCount = cols;
            dataIn_DKD.RowCount = rows;
            dataOut_DKD.ColumnCount = cols;
            dataOut_DKD.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataIn_DKD.Columns[i].Width = 30;
                dataOut_DKD.Columns[i].Width = 30;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataIn_DKD.Rows[r].Cells[c].Value = arr[r, c];
                }
            }
            arr = ds.GetMatrix(openFilePath);
            buttonDune_DKD.Enabled = true;
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAmout f = new FormAmout();
            f.ShowDialog();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[rows, cols];
            arr = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for(int c = 0;c < cols; c++)
                {
                    dataOut_DKD.Rows[r].Cells[c].Value = arr[r,c];
                }
            }
            Save_DKD.Enabled = true;
        }
        private void buttonsave(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();
            string p = saveFileDialog1.FileName;
            FileInfo f = new FileInfo(p);
            bool fileExe = f.Exists;
            if (fileExe)
            {
                File.Delete(p);
            }
            int rows = dataOut_DKD.RowCount;
            int cols = dataIn_DKD.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataOut_DKD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataOut_DKD.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(p, str + Environment.NewLine);
            str = "";
        }
    }
}

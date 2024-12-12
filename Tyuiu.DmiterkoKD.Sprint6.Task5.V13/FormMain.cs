using Tyuiu.DmiterkoKD.Sprint6.Task5.V13.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task5.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string p = @"C:\Users\rugis\AppData\Local\Temp\InPutDataFileTask5V13.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView_DKD.ColumnCount = 2;
            dataGridView_DKD.Columns[0].Width = 20;
            dataGridView_DKD.Columns[1].Width = 50;


            this.chartFun_DKD.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFun_DKD.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(p);

            for (int i = 0; i < nums.Length; i++)
            {
                dataGridView_DKD.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartFun_DKD.Series[0].Points.AddXY(i, nums[i]);
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad";
            txt.StartInfo.Arguments = p;
            txt.Start();
        }
        private void buttonHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-24-1 Дмитерко Кира Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

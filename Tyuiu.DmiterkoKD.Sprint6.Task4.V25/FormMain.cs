using Tyuiu.DmiterkoKD.Sprint6.Task4.V25.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int stary = Convert.ToInt32(Start_DKD.Text);
                int stop = Convert.ToInt32(End_DKD.Text);

                int len = ds.GetMassFunction(stary, stop).Length;

                double[] valueArr;
                valueArr = new double[len];
                valueArr = ds.GetMassFunction(stary, stop);

                this.chartFun_DKD.Titles.Add("График функции");
                this.chartFun_DKD.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFun_DKD.ChartAreas[0].AxisY.Title = "Ось Y";
                Result_DKD.Text = "";
                chartFun_DKD.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartFun_DKD.Series[0].Points.AddXY(stary, valueArr[i]);
                    Result_DKD.AppendText(valueArr[i] + Environment.NewLine);
                    stary++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-24-1 Дмитерко Кира Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.txt");
                FileInfo fileInfo = new FileInfo(filePath);
                File.WriteAllText(filePath, Result_DKD.Text);
                DialogResult d = MessageBox.Show("Файл " + filePath + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = filePath;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранение файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFun_DKD_Click(object sender, EventArgs e)
        {

        }
    }
}

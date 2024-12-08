using Tyuiu.DmiterkoKD.Sprint6.Task2.V15.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task2.V15
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
                int stary = Convert.ToInt32(textBoxX1_DKD.Text);
                int stop = Convert.ToInt32(textBoxX2_DKD.Text);

                int len = ds.GetMassFunction(stary, stop).Length;

                double[] valueArr;
                valueArr = new double[len];
                valueArr = ds.GetMassFunction(stary, stop);

                this.chartFun.Titles.Add("График функции");
                this.chartFun.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFun.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(stary), Convert.ToString(valueArr[i]));
                    this.chartFun.Series[0].Points.AddXY(stary, valueArr[i]);
                    stary++;
                }
            }
            catch 
            {
                MessageBox.Show("Ââåäåíû íåëëëííûå", "Îøèáêà!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDun_DKD.BackColor = Color.Red;
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDun_DKD.BackColor = Color.Green;
        }
        private void buttonDone_MouseDown(object sender, EventArgs e)
        {
            buttonDun_DKD.BackColor = Color.Blue;
        }
        private void buttonHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-24-1 Дмитерко Кира Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

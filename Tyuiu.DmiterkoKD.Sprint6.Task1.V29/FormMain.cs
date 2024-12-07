using Tyuiu.DmiterkoKD.Sprint6.Task1.V29.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int start = Convert.ToInt32(textBoxX_DKD.Text);
                int stop = Convert.ToInt32(textBoxX2_DKD.Text);
                string str;
                int len = (ds.GetMassFunction(start, stop)).Length;
                double[] valueArr;
                valueArr = new double[len];
                valueArr = ds.GetMassFunction(start, stop);

                I_DKD.Text = "";
                I_DKD.AppendText("+---------+---------+" + Environment.NewLine);
                I_DKD.AppendText("+    X    +   F(x)  +" + Environment.NewLine);
                I_DKD.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    str = String.Format("|{0,5:d}    |  {1,5:f2}   |", start, stop);
                    I_DKD.AppendText(str + Environment.NewLine);
                    start++;
                }
                I_DKD.AppendText("+---------+---------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåëëëííûå", "Îøèáêà!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarXC_ReyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}

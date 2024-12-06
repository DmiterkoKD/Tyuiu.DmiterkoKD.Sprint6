using Tyuiu.DmiterkoKD.Sprint6.Task0.V28.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task0.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_DKD.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxXX_DKD.Text)));
            }
            catch
            {
                MessageBox.Show("??????? ???????? ??????", "??????!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarXC_ReyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}

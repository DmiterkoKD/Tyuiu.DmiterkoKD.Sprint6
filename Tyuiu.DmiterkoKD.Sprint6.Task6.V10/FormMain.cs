using System.IO;
using Tyuiu.DmiterkoKD.Sprint6.Task6.V10.Lib;
namespace Tyuiu.DmiterkoKD.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "w";
            Res_DKD.Text = ds.CollectTextFromFile(str);
        }
        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            FromAbout fromAbout = new FromAbout();
            fromAbout.ShowDialog();
        }

        private void buttonOpenFile_ISI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DKD.ShowDialog();
           
            openFilePath = openFileDialogTask_DKD.FileName;
            In_DKD.Text = File.ReadAllText(openFilePath);
            Res_DKD.Text = Res_DKD.Text + " " + openFileDialogTask_DKD.FileName;
            Go_DKD.Enabled = true;
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialogTask_DKD.ShowDialog() == DialogResult.OK)
            {
                p = openFileDialogTask_DKD.FileName;
                In_DKD.Text = File.ReadAllText(p);
                Go_DKD.Enabled = true;
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Ñíà÷àëà âûáåðèòå ôàéë!");
                return;
            }
            string result = ds.CollectTextFromFile(path);
            textBoxOut.Text = result;
        }
    }
}

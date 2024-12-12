using Tyuiu.DmiterkoKD.Sprint6.Task7.V20.Lib;
using System.IO;
namespace Tyuiu.DmiterkoKD.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            TextBoxOutput_NVR.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog_NVR.ShowDialog();
            openFilePath = OpenFileDialog_NVR.FileName;
            TextBoxInput_NVR.Text = File.ReadAllText(openFilePath);
            GroupBoxOutput_NVR.Text = GroupBoxOutput_NVR.Text + " " + OpenFileDialog_NVR.FileName;
            ButtonDone_NVR.Enabled = true;

        }
    }
}

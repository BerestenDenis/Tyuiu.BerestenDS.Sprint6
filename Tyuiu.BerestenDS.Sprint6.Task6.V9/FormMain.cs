using System.Windows.Forms;
using Tyuiu.BerestenDS.Sprint6.Task6.V9.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task6.V9
{
    public partial class FormMain : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public FormMain()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoad.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}

using Tyuiu.BerestenDS.Sprint6.Task6.V9.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task6.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openfile;
        DataService ds = new DataService();
        private void buttoneDone_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult.Text = ds.CollectTextFromFile(str, openfile);
        }
        private void buttoneHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttoneFile_Click(object sender, EventArgs e)
        {
            openfileDialogTask.ShowDialog();

        }

    }
}

using Tyuiu.BerestenDS.Sprint6.Task5.V16.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V16.txt";
        private void buttoneDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width= 20;
            dataGridViewNums.Columns[1].Width= 50;
            double[] numsMass= new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i),Convert.ToString(numsMass[i]));
            }

        }
        private void buttoneOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt =new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttoneHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task5 Beresten Denis", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

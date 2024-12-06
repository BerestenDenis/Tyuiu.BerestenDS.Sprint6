using Tyuiu.BerestenDS.Sprint6.Task4.V28.Lib;

namespace Tyuiu.BerestenDS.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttoneDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult.Text = "";
                for(int i = 0; i < len; i++)
                {
                    textBoxResult.AppendText(valueArray[i]+Environment.NewLine);
                }

            }
            catch
            {
                MessageBox.Show("Eror","erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 4 Beresten Denis","Message", MessageBoxButtons.OK);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V28.txt";
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogResult = MessageBox.Show("file" + path + "save good");
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Error file","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

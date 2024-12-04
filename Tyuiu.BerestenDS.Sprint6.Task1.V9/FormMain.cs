using System.Drawing.Text;
using Tyuiu.BerestenDS.Sprint6.Task1.V9;
using Tyuiu.BerestenDS.Sprint6.Task1.V9.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task1.V9
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
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);
                string strline;
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+------+------+" + Environment.NewLine);
                textBoxResult.AppendText("|  x  |  F(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+------+------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,7:d}   ||{1, 7:f2}   |", startValue, valueArray[i]);
                    textBoxResult.AppendText(strline + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Error","error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("таск 1 выполнил берестень денис ибксб24-1","сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

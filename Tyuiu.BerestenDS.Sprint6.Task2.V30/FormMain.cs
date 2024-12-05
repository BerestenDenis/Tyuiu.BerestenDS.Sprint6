using Tyuiu.BerestenDS.Sprint6.Task2.V30.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task2.V30
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
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue.Text);
                double[] valueArray = ds.GetMassFunction(startValue, stopValue);


                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    startValue++;
                }


            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ñäåëàë ñòóäåíò ãð. ÈÁÊÑá-24-1 Øìèäò Àíäðåé Àíäðååâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK);
        }
    }
}

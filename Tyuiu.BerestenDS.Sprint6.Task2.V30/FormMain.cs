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
        private void textBox_StartValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_StopValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÑÌÀÐÒá-24-1 Öàð¸â Äàíèèë Èëüè÷", "!ACHTUNG!");
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox_StartValue.Text);
                int stopStep = Convert.ToInt32(textBox_StopValue.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] m = new double[len];
                m = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("график функций");
                this.chartFunction.ChartAreas[0].AxisX.Title = "X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(m[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, m[i]);
                    startStep++;
                }



            }
            catch
            {
                MessageBox.Show("Denis Beresten", "EA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {

        }
        private void start_Click(object sender, EventArgs e)
        {

        }
        private void chartFunction_Click(object sender, EventArgs e)
        {

        }
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

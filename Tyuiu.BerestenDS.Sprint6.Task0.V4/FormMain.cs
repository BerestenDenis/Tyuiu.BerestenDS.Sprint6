using Tyuiu.BerestenDS.Sprint6.Task0.V4.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX.Text)));
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void textBoxx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }
        private void buttonHelp_click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Выполнил Берестень Д.С. ИБКСБ24-1");
        }

    }
}

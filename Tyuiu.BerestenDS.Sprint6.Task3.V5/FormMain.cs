using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tyuiu.BerestenDS.Sprint6.Task3.V5.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 30, -20, 7, -8, 9 },
                                           { 32, 17, -14, -7, 33 },
                                           { 19, -19, -13, 14, -20 },
                                           { 11, 30, -1, 26, 6 },
                                           { 30, -15, -20, -5, 15 } };
        private void FormMain_Load(object sender, EventArgs e)
        {

            dataGridViewMatrix.ColumnCount = 5;
            dataGridViewMatrix.RowCount = 5;
            for (int i = 0; i <5; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 35;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i,j]);
                }
            }

        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 3 Beresten Denis ", "Message", MessageBoxButtons.OK);

        }
    }
}

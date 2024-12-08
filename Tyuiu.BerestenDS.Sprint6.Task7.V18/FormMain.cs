using Tyuiu.BerestenDS.Sprint6.Task7.V18.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string path = @"C:\DataSprint6\InPutDataFileTask7V18.csv";
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] buttonLoad_Click(string filepath)
        {
            string filedata = File.ReadAllText(filepath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;

        }
        private void buttonHelp_click(object sender, EventArgs e)
        {

        }
        private void buttoneDone_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.GetMatrix(path);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 8)
                    {
                        dataGridViewResult.Rows[i].Cells[j].Value = 11;
                        mtrx[i, j] = 11;
                    }
                    else
                    {
                        dataGridViewResult.Rows[i].Cells[j].Value = mtrx[i, j];
                    }
                }
            }

        }
    }
}

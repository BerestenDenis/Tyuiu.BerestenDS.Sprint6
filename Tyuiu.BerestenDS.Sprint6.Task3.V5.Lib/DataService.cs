using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int[] temp = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                temp[i] = matrix[2, i];
                Console.Write(matrix[2, i]);
            }
            Array.Sort(temp);
            for (int i = 0; i < rows; i++)
            {
                matrix[2, i] = temp[i];
                Console.Write(matrix[2, i]);
            }
            return matrix;
        }
    }
}

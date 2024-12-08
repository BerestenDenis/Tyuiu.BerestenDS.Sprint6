using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            var indices = Enumerable.Range(0, rows).ToArray();
            Array.Sort(indices, (i1, i2) => matrix[i1, 2].CompareTo(matrix[i2, 2]));
            int[,] sortedMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int originalIndex = indices[i];
                for (int j = 0; j < cols; j++)
                {
                    sortedMatrix[i, j] = matrix[originalIndex, j];
                }
            }

            return sortedMatrix;
        }
    }
}

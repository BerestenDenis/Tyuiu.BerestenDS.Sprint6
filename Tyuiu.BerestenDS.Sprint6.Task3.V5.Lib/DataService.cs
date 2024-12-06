using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            var sortedArray = Enumerable.Range(0, matrix.GetLength(0))
                .Select(i => new {
                    Col0 = matrix[i, 0],
                    Col1 = matrix[i, 1],
                    Col2 = matrix[i, 2],
                    Col3 = matrix[i, 3],
                    Col4 = matrix[i, 4]
                })
                .OrderBy(row => row.Col2) // Сортируем по третьему столбцу
                .ToArray();
            return matrix;
        }
    }
}

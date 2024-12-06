using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Проверяем, что матрица имеет хотя бы 3 столбца
            if (cols < 3)
            {
                throw new ArgumentException("Матрица должна содержать как минимум 3 столбца.");
            }

            // Преобразуем матрицу в список кортежей
            var tempList = Enumerable.Range(0, rows)
                .Select(i => (matrix[i, 0], matrix[i, 1], matrix[i, 2], matrix[i, 3], matrix[i, 4]))
                .ToList();

            // Сортируем список по третьему элементу
            var sortedList = tempList.OrderBy(row => row.Item3).ToList();

            // Создаем новый отсортированный массив
            int[,] sortedMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                sortedMatrix[i, 0] = sortedList[i].Item1;
                sortedMatrix[i, 1] = sortedList[i].Item2;
                sortedMatrix[i, 2] = sortedList[i].Item3;
                sortedMatrix[i, 3] = sortedList[i].Item4;
                sortedMatrix[i, 4] = sortedList[i].Item5;
            }

            return sortedMatrix;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Проверяем, что массив имеет хотя бы 3 столбца
            if (cols < 3)
            {
                throw new ArgumentException("Массив должен содержать как минимум 3 столбца.");
            }

            // Создаем временный массив для хранения строк
            var tempArray = new (int, int, int, int, int)[rows];

            // Заполняем временный массив
            for (int i = 0; i < rows; i++)
            {
                tempArray[i] = (matrix[i, 0], matrix[i, 1], matrix[i, 2], matrix[i, 3], matrix[i, 4]);
            }

            // Сортируем временный массив по третьему элементу
            Array.Sort(tempArray, (a, b) => a.Item3.CompareTo(b.Item3));

            // Создаем новый отсортированный массив
            int[,] sortedMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                sortedMatrix[i, 0] = tempArray[i].Item1;
                sortedMatrix[i, 1] = tempArray[i].Item2;
                sortedMatrix[i, 2] = tempArray[i].Item3;
                sortedMatrix[i, 3] = tempArray[i].Item4;
                sortedMatrix[i, 4] = tempArray[i].Item5;
            }

            return sortedMatrix;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var sortedMatrix = matrix.Cast<int>()
                                     .Select((value, index) => new { value, index })
                                     .GroupBy(x => x.index / cols)
                                     .Select(g => g.Select(x => x.value).ToArray())
                                     .OrderBy(row => row[0])
                                     .ToArray();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = sortedMatrix[i][j];
                }
            }

            return matrix;
        }

    }
}

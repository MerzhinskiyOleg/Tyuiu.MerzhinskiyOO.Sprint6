using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] matrixx =
            {
                { -13, -15, 14, 2, 27 },
                { -8, 14, -10, 33, 0 },
                { -3, 7, -11, -11, 23 },
                { 1, -20, 15, -16, 34 },
                { 27, 1, -1, 5, 1 }
            };

            var array = new List<int[]>();
            for (int i = 0; i < rows; i++)
            {
                var row = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }
                array.Add(row);
            }//dsfs

            array = array.OrderBy(row => row[0]).ToList();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = array[i][j];
                }
            }

            return matrixx;
        }
    }
}

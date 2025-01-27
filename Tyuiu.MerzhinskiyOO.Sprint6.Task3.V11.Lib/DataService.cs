using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int[] fourthColumn = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                fourthColumn[i] = matrix[i, 3];
            }

            Array.Sort(fourthColumn);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = fourthColumn[i];
            }

            return matrix;
        }
    }
}

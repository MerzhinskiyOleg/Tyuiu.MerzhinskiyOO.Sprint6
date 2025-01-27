using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;

            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (result[i, 1] < 0)
                {
                    result[i, 1] = 1;
                }
            }

            return result;
        }
    }
}

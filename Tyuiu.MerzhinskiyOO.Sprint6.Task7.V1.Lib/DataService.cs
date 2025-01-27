using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            int rows;
            int cols;

            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] aValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] lineData = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    aValues[r, c] = Convert.ToInt32(lineData[c]);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                if (aValues[r, 8] < -10 || aValues[r, 8] > 10)
                {
                    aValues[r, 8] = 0;
                }
            }

            return aValues;
        }
    }
}

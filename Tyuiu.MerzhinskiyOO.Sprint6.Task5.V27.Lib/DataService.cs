using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double[] numsArray = lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => Convert.ToDouble(line))
                .ToArray();

            numsArray = numsArray.Where(val => val % 5 != 0).ToArray();

            return numsArray;
        }

    }
}

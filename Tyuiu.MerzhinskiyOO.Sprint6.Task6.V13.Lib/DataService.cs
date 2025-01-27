using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string path)
        {
            Console.WriteLine(path);
            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (words.Length > 1)
                {
                    result.Append(words[^2] + " ");
                }
            }

            return result.ToString().Trim();
        }
    }
}

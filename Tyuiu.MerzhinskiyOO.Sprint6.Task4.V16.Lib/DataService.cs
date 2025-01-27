using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MerzhinskiyOO.Sprint6.Task4.V16.Lib
{
    public class DataService : ISprint6Task4V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(Math.Cos(i) / (i - 0.4) + Math.Sin(i) * (8 * i) + 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapkoDD.Sprint3.Task5.V18.Lib
{
    public class DataService : ISprint3Task5V18
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 1;
            for (double i = startValue1; i <= stopValue1; i++)
            {
                for (double k = startValue2; k <= stopValue2; k++)
                {
                    res = res + (Math.Cos(x) + (Math.Pow(k,2)/2)); 
                }
            }
            return Math.Round(res, 3);
        }
    }
}
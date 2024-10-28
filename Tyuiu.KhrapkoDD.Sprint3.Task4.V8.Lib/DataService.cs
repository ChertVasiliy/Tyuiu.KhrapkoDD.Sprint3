using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapkoDD.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                else
                {
                    double y = x / Math.Sin(x) + 0.5;
                    res = res * y;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
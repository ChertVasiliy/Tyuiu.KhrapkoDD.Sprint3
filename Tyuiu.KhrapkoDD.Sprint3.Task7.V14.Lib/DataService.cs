using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapkoDD.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res; int len = (stopValue - startValue) + 1; res = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 1 == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    double y = 2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1));
                    res[count] = y;
                    count++;
                }
            }
            return res;
        }
    }
}
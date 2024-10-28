using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapkoDD.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                SumSeries += Math.Pow(1.0/(Math.Pow(value,i)),2.0);
            }
            return Math.Round(SumSeries, 3);//
        }
    }
}
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapkoDD.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double P = 1;
            while (startValue <= stopValue)
            {
                P = P * Math.Pow(1 / Math.Cos(value + Math.Pow(value, startValue)), startValue);
                startValue++;
            }
            return Math.Round(P, 3);
        }
        ////
    }
}

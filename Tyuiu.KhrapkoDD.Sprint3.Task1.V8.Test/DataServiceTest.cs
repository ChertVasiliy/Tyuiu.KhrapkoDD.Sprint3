using Tyuiu.KhrapkoDD.Sprint3.Task1.V8.Lib;

namespace Tyuiu.KhrapkoDD.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, stopValue, startValue);

            double wait = 6.621;

            Assert.AreEqual(wait, res);

        }
    }
}
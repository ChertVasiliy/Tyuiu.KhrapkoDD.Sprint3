using Tyuiu.KhrapkoDD.Sprint3.Task0.V11.Lib;

namespace Tyuiu.KhrapkoDD.Sprint3.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, stopValue, startValue);

            double wait = 0.042;

            Assert.AreEqual(wait, res);
        }
    }
}
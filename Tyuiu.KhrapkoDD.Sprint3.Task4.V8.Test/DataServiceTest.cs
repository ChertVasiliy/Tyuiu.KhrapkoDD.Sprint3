using Tyuiu.KhrapkoDD.Sprint3.Task4.V8.Lib;

namespace Tyuiu.KhrapkoDD.Sprint3.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 5;
            int stopValue = 5;
            double wait = 1.737;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
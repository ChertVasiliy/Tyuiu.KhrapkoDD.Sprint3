using Tyuiu.KhrapkoDD.Sprint3.Task6.V18.Lib;

namespace Tyuiu.KhrapkoDD.Sprint3.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 9; 
            int stopValue = 18;
            int wait = 95;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
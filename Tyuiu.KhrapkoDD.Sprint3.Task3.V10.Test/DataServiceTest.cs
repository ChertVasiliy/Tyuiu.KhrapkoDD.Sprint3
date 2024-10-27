using Tyuiu.KhrapkoDD.Sprint3.Task3.V10.Lib;

namespace Tyuiu.KhrapkoDD.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "ppp";
            char item = 'p';

            int res = ds.DeleteCharInString(value, item);

            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
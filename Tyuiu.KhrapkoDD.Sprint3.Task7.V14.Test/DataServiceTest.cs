using Tyuiu.KhrapkoDD.Sprint3.Task7.V14.Lib;

namespace Tyuiu.KhrapkoDD.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5; 
            int stopValue = 5;
            int len = stopValue - startValue + 1; 
            double[] waitres; 
            waitres = new double[len];

            waitres[0] = -19.62;
            waitres[1] = -17.12;
            waitres[2] = -18.15;
            waitres[3] = -62.13;
            waitres[4] = -24.92;
            waitres[5] = -5.00;
            waitres[6] = -1.46;
            waitres[7] = 1.57;
            waitres[8] = 6.38;
            waitres[9] = 32.78;
            waitres[10] = 225.11;
          
            double[] res; res = new double[len]; res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, waitres);
        }
    }
}
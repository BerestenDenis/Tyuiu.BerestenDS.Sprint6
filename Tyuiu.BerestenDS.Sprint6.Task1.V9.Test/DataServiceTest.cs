using Tyuiu.BerestenDS.Sprint6.Task1.V9.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task1.V9.Test
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

            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { -19.62, -17.12, -18.15, -63.13, -24.92, -5, -1.46, 1.57, 6.38, 32.78, 225.11 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
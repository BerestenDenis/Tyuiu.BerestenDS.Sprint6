using Tyuiu.BerestenDS.Sprint6.Task2.V30.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task2.V30.Test
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

            double[] wait = {};

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
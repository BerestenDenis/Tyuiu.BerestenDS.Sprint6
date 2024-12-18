using Tyuiu.BerestenDS.Sprint6.Task7.V18.Lib;
namespace Tyuiu.BerestenDS.Sprint6.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask7V18.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = {{-12,-18,16,2,-20,12,-15,-3,0,-19},
                           {15,15,12,12,-1,-18,10,-3,-12,-17},
                           {6,4,11,4,8,7,-13,15,-3,-15},
                           {10,9,7,16,12,20,-12,-13,9,-17},
                           {-11,-5,-9,15,-5,0,6,19,5,9},
                           {13,4,10,3,-20,7,0,14,-20, 8},
                           {-18, -12, -6,  -14, -12, -8,  -17, -10, 8,   3},
                           {15,  -14, 10,  -12, -18, 19,  -8,  5,   -19, -7},
                           {10,  1,   4,   20,  -11, 1,   18,  0,   -17, -11 },
                           {-12, 7,   -18, -11, 8,   -15, -2,  7,   11,  8} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
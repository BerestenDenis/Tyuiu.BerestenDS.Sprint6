using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double y = ((5 * i + 2.5) / Math.Sin(i) + 3) + 2 * i + Math.Cos(i);

                if (Math.Sin(i) == -1)
                {
                    res[i] = 0;
                }
                res[count] = y;

                count++;
            }
            return res;
        }
    }
}

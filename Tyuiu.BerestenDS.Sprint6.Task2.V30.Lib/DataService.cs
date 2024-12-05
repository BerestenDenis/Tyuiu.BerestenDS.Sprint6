using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = Math.Abs(startValue) + stopValue + 1;
            int count = 0;
            double[] res = new double[len];
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((2 - i) == 0)
                {
                    res[count] = 0;
                }
                else
                {
                    res[count] = ((5 * i + 2.5) / (Math.Sin(i)+3)) + (2 * i + Math.Cos(i));
                    res[count] = Math.Round((res[count]), 3);
                }
                count++;

            }
            return res;
        }
    }
}

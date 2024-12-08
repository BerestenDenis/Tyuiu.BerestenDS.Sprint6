using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerestenDS.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string last;
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    resStr = resStr + lines.Split(' ').LastOrDefault()+ " ";
                }

            }
            return Regex.Replace(resStr, @"\s+$", "");
        }
    }
}

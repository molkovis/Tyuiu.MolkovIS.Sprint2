using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolkovIS.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] =  x == y;
            result[1] =  7*x != y;
            result[2] =  x < y;
            result[3] =  8*x > y;
            result[4] =  8*x <= y;
            result[5] =  6*x >= y;

            return result;
        }
    }
}

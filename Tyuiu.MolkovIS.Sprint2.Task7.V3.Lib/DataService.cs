using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.MolkovIS.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if ((Math.Pow(x, 2) + Math.Pow(y - 1, 2) <= 1) & (1-Math.Pow(x,2) >= y))
            {
                res = true;
            }
            return res;
        }
    }
}

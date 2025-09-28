using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolkovIS.Sprint2.Task2.V1.Lib
{
    public class DataService : ISprint2Task2V1
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 5 && x <= 12) && (y >= 5) && (y <= 7))
            {
                res = true;
            }
            else if ((x >= 6 && x <= 8) && (y >= 8 && y <= 11))
            {
                res = true;
            }
            else if ((x >= 3 && x <= 5) && (y >= 3 && y <= 4))
            {
                res = true;
            }
            else if ((x >= 3 && x <= 4) && (y == 7))
            {
                res = true;
            }
            else if ((x == 12) && (y >= 3 && y <= 11))
            {
                res = true;
            }
            else if ((x == 13) && (y >= 6 && y <= 8))
            {
                res = true;
            }
            else if ((x == 9) && (y >= 3 && y <= 4))
            {
                res = true;
            }
            else if ((y == 12) && (x >= 7 && x <= 8))
            {
                res = true;
            }
            else if ((y == 11) && (x >= 3 && x <= 5))
            {
                res = true;
            }
            else if ((x == 4) && (y >= 12 && y <= 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;



        }
    }
}

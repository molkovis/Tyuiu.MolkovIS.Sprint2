using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolkovIS.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b)|(c <= d); //f
            res[1] = (a == b)&(c <= d); //f
            res[2] = (a == b)||(c <= d); //f
            res[3] = (a == b)&&(c <= d); //f
            res[4] = !(a == b); //t
            res[5] = (a == b)^(c <= d); //f
            return res;
        }
    }
}

using Tyuiu.MolkovIS.Sprint2.Task4.V17.Lib;

namespace Tyuiu.MolkovIS.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        
        DataService ds = new DataService();
        
        
        [TestMethod]
        public void ValidCalc1()
        {
            double x = 25;
            double y = 4;
            double wait = 1298.767;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait,res);

        }
        [TestMethod]
        public void ValidCalc2()
        {
            double x = 1;
            double y = 16;
            double wait = 28;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalc3()
        {
            double x = 5;
            double y = 5;
            double wait = 5.48;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

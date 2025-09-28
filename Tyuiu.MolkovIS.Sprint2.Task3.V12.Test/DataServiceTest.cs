using Tyuiu.MolkovIS.Sprint2.Task3.V12.Lib;

namespace Tyuiu.MolkovIS.Sprint2.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        
        DataService ds = new DataService();
        
        
        
        [TestMethod]
        public void Con1()
        {
            double x = 6;
            double wait = 13.530;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
            
        }
        [TestMethod]
        public void Con2()
        {
            double x = 0;
            double wait = 1.540;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Con3()
        {
            double x = -6;
            double wait = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Con4()
        {
            double x = -30;
            double wait = -329.967;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}

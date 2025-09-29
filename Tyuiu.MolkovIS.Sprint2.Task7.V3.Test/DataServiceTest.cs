using Tyuiu.MolkovIS.Sprint2.Task7.V3.Lib;




namespace Tyuiu.MolkovIS.Sprint2.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();

            double x = 0.25;
            double y = 0.25;
            bool wait = true;
            Assert.AreEqual(wait, dataService.CheckDotInShadedArea(x, y));
        }
    }
}

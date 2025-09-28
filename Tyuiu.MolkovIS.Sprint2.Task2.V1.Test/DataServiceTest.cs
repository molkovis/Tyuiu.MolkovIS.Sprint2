using Tyuiu.MolkovIS.Sprint2.Task2.V1.Lib;



namespace Tyuiu.MolkovIS.Sprint2.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTEst
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService dataService = new DataService();
            int x1 = 5;
            int y1 = 5;

            Assert.AreEqual(true, dataService.CheckDotInShadedArea(x1, y1));



        }
    }
}

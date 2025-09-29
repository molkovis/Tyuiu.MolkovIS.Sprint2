using Tyuiu.MolkovIS.Sprint2.Task6.V5.Lib;


namespace Tyuiu.MolkovIS.Sprint2.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService dataService = new DataService();

            Assert.AreEqual("валет", dataService.FindCardValue(11));
            Assert.AreEqual("десятка", dataService.FindCardValue(10));
            Assert.AreEqual("шестерка", dataService.FindCardValue(6));
            Assert.AreEqual("туз", dataService.FindCardValue(14));
        }
    }
}

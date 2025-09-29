using Tyuiu.MolkovIS.Sprint2.Task5.V4.Lib;

namespace Tyuiu.MolkovIS.Sprint2.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService dataService = new DataService();

            string s1 = "пики";
            string s2 = "трефы";
            string s3 = "бубны";
            string s4 = "червы";

            Assert.AreEqual(s1, dataService.FindCardSuit(1));
            Assert.AreEqual(s2, dataService.FindCardSuit(2));
            Assert.AreEqual(s3, dataService.FindCardSuit(3));
            Assert.AreEqual(s4, dataService.FindCardSuit(4));




        }
    }
}

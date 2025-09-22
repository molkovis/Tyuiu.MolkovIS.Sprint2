using Tyuiu.MolkovIS.Sprint2.Task0.V29.Lib;


namespace Tyuiu.MolkovIS.Sprint2.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            var dataService = new DataService();
            bool[] expected = new bool[6] { false, false, true, true, false, false };
            bool[] actual = dataService.GetCompareOperations(105, 735);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

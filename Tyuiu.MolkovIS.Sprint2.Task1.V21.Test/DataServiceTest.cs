using Tyuiu.MolkovIS.Sprint2.Task1.V21.Lib;

namespace Tyuiu.MolkovIS.Sprint2.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLogic()
        {
            bool[] nice = { false, false, false, false, true,false };
            DataService dataService = new DataService();
            CollectionAssert.AreEqual(nice, dataService.GetLogicOperations(696, 987, 696, 155));

        }
    }
}

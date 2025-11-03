using Tyuiu.PankovaAA.Sprint4.Task0.V29.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 0, 3, 0, 10 };
            int res = ds.GetSum(numsArray);
            int wait = 17;
            Assert.AreEqual(wait, res);
        }
    }
}

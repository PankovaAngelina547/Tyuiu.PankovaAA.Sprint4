using Tyuiu.PankovaAA.Sprint4.Task2.V27.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {

            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 3, 5, 2, 7, 4, 6, 2, 5, 4, 7 };
            int res = ds.Calculate(array);
            int wait = 2 + 4 + 6 + 2 + 4 + 6 + 2 + 4;
            Assert.AreEqual(wait, res);
        }
    }
}

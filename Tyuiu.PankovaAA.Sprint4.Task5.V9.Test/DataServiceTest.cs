using Tyuiu.PankovaAA.Sprint4.Task5.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] {
                { 1, -2, 3, -4, 0 },
                { -1, 2, -3, 4, 1 },
                { 2, -1, 0, 3, -2 },
                { -3, 1, -2, 2, 0 },
                { 0, -4, 4, -1, 3 }
            };

            int res = ds.Calculate(mas);
            int wait = 11;

            Assert.AreEqual(wait, res);

        }
    }
}

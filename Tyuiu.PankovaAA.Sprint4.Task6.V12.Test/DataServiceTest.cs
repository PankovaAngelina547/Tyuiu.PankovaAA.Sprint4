using Tyuiu.PankovaAA.Sprint4.Task6.V12.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string[] data = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

            string[] res = ds.Calculate(data);

            string[] wait = { "Украина", "Молдова", "Эстония" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

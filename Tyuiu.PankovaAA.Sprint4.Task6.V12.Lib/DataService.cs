using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PankovaAA.Sprint4.Task6.V12.Lib
{
    public class DataService : ISprint4Task6V12
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, element => element.Length == 7);
        }
    }
}

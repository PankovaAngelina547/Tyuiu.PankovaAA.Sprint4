using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PankovaAA.Sprint4.Task0.V29.Lib
{
    public class DataService
    {
        public int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
        

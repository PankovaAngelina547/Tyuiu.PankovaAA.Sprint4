using Tyuiu.PankovaAA.Sprint4.Task6.V12.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #4                                                              *");
            Console.WriteLine("*  Тема: класс array                                                      *");
            Console.WriteLine("*  Задание #06                                                            *");
            Console.WriteLine("*  Вариант #12                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            string[] data = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

            Console.WriteLine("Исходный массив стран:");
            PrintArray(data);


            string[] result = ds.Calculate(data);

            Console.WriteLine("\nЭлементы массива длиной 7 символов:");
            PrintArray(result);

            Console.ReadKey();
        }

        static void PrintArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine($"'{item}' - {item.Length} символов");









            }






        }
    }
}
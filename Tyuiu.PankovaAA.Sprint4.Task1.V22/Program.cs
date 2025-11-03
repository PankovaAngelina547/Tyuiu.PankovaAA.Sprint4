using Tyuiu.PankovaAA.Sprint4.Task1.V22.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #4                                                              *");
            Console.WriteLine("*  Тема: одномерные массивы(ввод с клавиатуры)                            *");
            Console.WriteLine("*  Задание #01                                                            *");
            Console.WriteLine("*  Вариант #22                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int[] array = { 8, 5, 4, 4, 3, 9, 9, 3, 4, 4, 9 };
            int product = ds.Calculate(array);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            Console.WriteLine("Нечетные элементы: 5 * 3 * 9 * 9 * 3 * 9 = " + product);

            Console.ReadKey();



        }

    }
}
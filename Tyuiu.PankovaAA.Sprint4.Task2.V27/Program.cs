using Tyuiu.PankovaAA.Sprint4.Task2.V27.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task2.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #4                                                              *");
            Console.WriteLine("*  Тема: одномерные массивы(генератор случайных чисел)                    *");
            Console.WriteLine("*  Задание #02                                                            *");
            Console.WriteLine("*  Вариант #27                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 7 подсчитать сумму четных элементов      *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int[] array = { 2, 4, 6, 3, 5, 2, 7, 4, 6, 2, 5, 4, 7 };
            int sum = ds.Calculate(array);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            Console.WriteLine("Четные элементы: 2 + 4 + 6 + 2 + 4 + 6 + 2 + 4 = " + sum);

            Console.ReadKey();



        }

    }
}
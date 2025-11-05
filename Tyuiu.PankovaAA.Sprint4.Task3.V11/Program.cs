using Tyuiu.PankovaAA.Sprint4.Task3.V11.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task3.V11
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
            Console.WriteLine("*  Задание #03                                                            *");
            Console.WriteLine("*  Вариант #11                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int[,] matrix = {
            { 8, 6, 9, 4, 5 },
            { 9, 4, 8, 5, 6 },
            { 9, 7, 9, 8, 4 },
            { 4, 6, 5, 7, 8 },
            { 6, 6, 7, 6, 4 }
        };
            int count = ds.Calculate(matrix);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            Console.WriteLine("Нечетные элементы: 9, 5, 9, 5, 9, 7, 9, 5, 7, 7");
            Console.WriteLine("Всего: 10 элементов");


            Console.ReadKey();



        }

    }
}

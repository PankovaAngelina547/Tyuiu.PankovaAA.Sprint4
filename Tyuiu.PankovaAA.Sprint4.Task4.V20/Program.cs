using Tyuiu.PankovaAA.Sprint4.Task4.V20.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #4                                                              *");
            Console.WriteLine("*  Тема: двумерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("*  Задание #04                                                            *");
            Console.WriteLine("*  Вариант #20                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 8. Заменить четные элементы *");
            Console.WriteLine("* массива на 1                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            Console.WriteLine("Введите массив 5x5 (значения от 4 до 8):");

            int[,] matrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    int value = Convert.ToInt32(Console.ReadLine());


                    if (value < 4 || value > 8)
                    {
                        Console.WriteLine("Ошибка! Значение должно быть от 4 до 8");
                        j--;
                        continue;
                    }

                    matrix[i, j] = value;


                   



                }

            }
        }
    }
}
using Tyuiu.PankovaAA.Sprint4.Task5.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #4                                                              *");
            Console.WriteLine("*  Тема: одномерные массивы(статический ввод)                             *");
            Console.WriteLine("*  Задание #00                                                            *");
            Console.WriteLine("*  Вариант #29                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива.  {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

           




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            int[,] matrix = new int[5, 5] {
                { 1, -2, 3, -4, 0 },
                { -1, 2, -3, 4, 1 },
                { 2, -1, 0, 3, -2 },
                { -3, 1, -2, 2, 0 },
                { 0, -4, 4, -1, 3 }
            };

            Console.WriteLine("Матрица 5x5:");
            PrintMatrix(matrix);

            int result = ds.Calculate(matrix);

            Console.WriteLine($"Количество положительных элементов: {result}");
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }

    }
}

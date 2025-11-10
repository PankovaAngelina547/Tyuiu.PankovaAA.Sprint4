using Tyuiu.PankovaAA.Sprint4.Task7.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint4.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 3;
            string str = "864299753";
            Console.Title = "Спринт #4 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #4                                                              *");
            Console.WriteLine("*  Тема:                                                                  *");
            Console.WriteLine("*  Задание #07                                                            *");
            Console.WriteLine("*  Вариант #09                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            int index = 0;
            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            
            int result = ds.Calculate(rows, columns, str);

            Console.WriteLine($"\nКоличество четных чисел: {result}");

           
            Console.WriteLine("\nАнализ четности:");
            foreach (char c in str)
            {
                int num = int.Parse(c.ToString());
                string parity = (num % 2 == 0) ? "четное" : "нечетное";
                Console.WriteLine($"{num} - {parity}");
            }

            Console.ReadKey();
        }

        



        
    }
}
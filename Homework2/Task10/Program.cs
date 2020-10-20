/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
*/
using System;

namespace Task10
{
    class Program
    {
        public static string ReverseNumber(int x)
        {
            x = Math.Abs(x);
            return ($"{x % 10}{Environment.NewLine}{x % 100 / 10}{Environment.NewLine}{x / 100 % 10}{Environment.NewLine}{x / 1000}");
        }

        public static void Main(string[] args)
        {
            do
            {

                int x = 0;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите четырехзначное число");
                    str = Console.ReadLine();
                }
                while (!int.TryParse(str, out x));
                if (999 < Math.Abs(x) && Math.Abs(x) < 10000)
                {
                    Console.WriteLine(ReverseNumber(x));
                    Console.WriteLine("Для выхода нажмите ESC");
                }
                else
                {
                    Console.WriteLine("Это не четырехзначное число");
                    Console.WriteLine("Для выхода нажмите ESC");
                }
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}

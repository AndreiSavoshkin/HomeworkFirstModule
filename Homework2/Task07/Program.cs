/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22
Ввести значение x и вывести значение полинома: F(x) = 12x4 + 9x3 - 3x2 + 2x – 4. Не применять возведение в степень. 
Использовать минимальное количество операций умножения.

*/
using System;

namespace Task08
{
    class Program
    {
        public static double CountPolynom(double x)
        {
            //переменные для вычисления степени числа х.
            double xV4, xV3, xV2, result;
            xV2 = x * x;
            xV3 = xV2 * x;
            xV4 = xV3 * x;
            result = 12 * xV4 + 9 * xV3 - 3 * xV2 + 2 * x - 4;
            return result;
        }

        public static void Main(string[] args)
        {
            do
            {

                double x;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите значение x");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out x));

                Console.WriteLine(CountPolynom(x));
                Console.WriteLine("Для выхода нажмите ESC");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}
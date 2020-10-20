/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
*/
using System;

namespace Task11
{
    class Program
    {
        public static bool NeravenstvoTriangle(double x, double y, double z)
        {
            double epsilon = 0.001;
            return ((y + z - x) > epsilon && (x + z - y) > epsilon && (x + y - z) > epsilon);

        }

        public static void Main(string[] args)
        {
            do
            {

                double x = 0, y = 0, z = 0;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите значение x");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out x));
                do
                {
                    Console.WriteLine("Введите значение y");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out y));
                do
                {
                    Console.WriteLine("Введите значение z");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out z));

                Console.WriteLine(NeravenstvoTriangle(x, y, z));
                Console.WriteLine("Для выхода нажмите ESC");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}

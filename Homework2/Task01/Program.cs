/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
*/
using System;

namespace Task01
{
    class Program
    {
        //method of calculating n-number.
        public static int CalculateBine(uint n)
        {
            double b = (1 + Math.Sqrt(5)) / 2;
            double un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
            return (int)(un + 0.5);
        }
        static void Main(string[] args)
        {
            int i = 1;
            //a repetitive cycle for re-solving the problem.
            while (i == 1)
            {
                uint n;
                int res;
                string line;
                do
                {
                    Console.Write("Введите номер члена ряда: ");
                    line = Console.ReadLine();
                }
                while (!uint.TryParse(line, out n));
                res = CalculateBine(n);
                Console.WriteLine("Число Фибоначчи: " + res);
                Console.WriteLine("Для выхода из программы нажмите ESC.");
                //comparing to Escape.
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    i = 0;
            }
        }
    }
}

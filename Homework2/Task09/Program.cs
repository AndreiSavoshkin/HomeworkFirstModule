/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
*/
using System;

namespace Task09
{
    class Program
    {
        public static string SolveEquation(double A, double B, double C)
        {
            double D;
            string result;
            D = B * B - 4 * A * C;
            result = A == 0
                ? (B == 0
                    ? (C == 0
                        ? "Уравнение имеет бесконечно много корней."
                        : "Уравнение корней не имеет.")
                    : "Уравнение имеет один корень: х = " + (-1 * C / B).ToString("F3"))
                : (D > 0
                    ? "Уравнение имеет два действительных корня: x1 = " + ((-B + Math.Sqrt(D)) / (2 * A)).ToString("F3") + ", x2 = " + ((-B - Math.Sqrt(D)) / (2 * A)).ToString("F3")
                    : (D == 0
                        ? "Уравнение имеет один корень: х = " + (-B / (2 * A)).ToString("F3")
                        : "Уравнение имеет два мнимых корня.")
                  );
            return result;
        }

        public static void Main(string[] args)
        {
            do
            {

                double A, B, C;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите значение коэффициента А");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out A));
                do
                {
                    Console.WriteLine("Введите значение коэффициента В");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out B));
                do
                {
                    Console.WriteLine("Введите значение коэффициента С");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out C));

                Console.WriteLine(SolveEquation(A, B, C));
                Console.WriteLine("Для выхода нажмите ESC");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}

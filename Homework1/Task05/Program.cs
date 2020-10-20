//Вычислить значение гипотенузы по введенным значениям пользователем катетов
using System;

namespace Task04
{
    class Program
    {
        static void Main()
        {
            double a, b;
            //считывание строк, содержащих значение катетов
            string input_a = Console.ReadLine();
            string input_b = Console.ReadLine();
            if (!(double.TryParse(input_a, out a) & double.TryParse(input_b, out b))) //проверка на правильность ввода первого катета
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                if (a > 0 & b > 0)
                {
                    double c = Math.Sqrt(a * a + b * b); //вычисление значения гипотенузы с использованием Math
                    Console.WriteLine(c);
                }
                else
                    Console.WriteLine("Incorrect input");
            }
        }
    }
}
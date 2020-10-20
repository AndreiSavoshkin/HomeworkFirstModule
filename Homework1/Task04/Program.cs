//Вычислить значения силы тока и мощности,используя введенные значения напряжения и сопротивления
using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            // считывание строк, содержащие значения U и R
            Console.WriteLine("Введите значение U и R");
            string input_U = Console.ReadLine();
            string input_R = Console.ReadLine();
            double U, R;
            if (!(double.TryParse(input_U, out U) & double.TryParse(input_R, out R))) //проверка на правильность ввода
            {
                Console.WriteLine("Ошибка ввода");
            }
            else
            {
                if (!(double.Parse(input_U) >= 0 & double.Parse(input_R) > 0)) //проверка на неотрицательность значения U
                    {
                        Console.WriteLine("Ошибка ввода значение (помни про положительность чисел)");
                    }
                else
                    {
                            double I = U / R;
                            double P = U * U / R;
                            Console.WriteLine($"Значение I = {I.ToString("F4")}"); //вывод с 4 знаками после запятой вещественного числа
                            Console.WriteLine($"Значение P = {P.ToString("F4")}");
                            Console.ReadLine();
                     }

             }
        }
    }
}

using System;

namespace Task5
{
    class Program
    {
        static double GetFunction(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            else
            {
                return Math.Sin(Math.PI * (x - 1) / 2);
            }
        }
        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.WriteLine("Введите х");
            }
            while (!double.TryParse(Console.ReadLine(), out x));
            Console.WriteLine($"{GetFunction(x):f3}");

        }
    }
}

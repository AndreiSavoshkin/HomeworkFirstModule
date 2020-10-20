using System;

namespace Task4
{
    class Program
    {
        static double GetFunction(double x, double y)
        {
            if ((x < y) && (x > 0))
            {
                return x + Math.Sin(y);
            }
            else if ((x > y) && (x < 0))
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * x * y;
            }
        }
        static void Main(string[] args)
        {
            double x, y;
            do
            {
                Console.WriteLine("Введите x и y");
            }
            while (!double.TryParse(Console.ReadLine(), out x) || !double.TryParse(Console.ReadLine(), out y));
            Console.WriteLine($"{GetFunction(x,y):f3}");
        }
    }
}

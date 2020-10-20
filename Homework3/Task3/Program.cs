using System;

namespace Task3
{
    class Program
    {
        static bool CheckGunctionG(double x, double y)
        {
            double R = 2;
            double p = Math.Sqrt(x * x + y * y);
            double cosq = x / p;
            bool angle = cosq >= 0 ? (cosq >= 1 / Math.Sqrt(2)) : (cosq > 0);
            return (p <= R) && (cosq >= 0) && angle;
        }
        static void Main()
        {
            double x, y;
            do
            {
                Console.WriteLine("Введите x и y");
            }
            while (!double.TryParse(Console.ReadLine(), out x) || !double.TryParse(Console.ReadLine(), out y));
            Console.WriteLine(CheckGunctionG(x, y));
        }
    }
}

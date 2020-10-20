using System;

namespace Task6
{
    class Program
    {
        static int GetCabinetNumber(int a, int b, int c)
        {
            return a % 100 < b % 100
                    ? (a % 100 < c % 100
                        ? a
                        : (c % 100 < b % 100
                            ? c
                            : b))
                    : (b % 100 < c % 100
                        ? b
                        : c % 100 < a % 100
                            ? c
                            : b);
        }
        static void Main(string[] args)
        {
            int a, b, c;
            do
            {
                Console.WriteLine("Input a,b,c");
            }
            while (!int.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out b) || !int.TryParse(Console.ReadLine(),out c));
            Console.WriteLine(GetCabinetNumber(a,b,c));
        }
    }
}

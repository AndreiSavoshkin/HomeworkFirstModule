using System;

namespace Task01
{
    class Program
    {
        private const int left = 1;
        private const int right = 20;
        static void GetABC()
        {
            for (var i = left; i <= right; i++)
            {
                for (var j = left; j <= right; j++)
                {
                    for (var k = left; k <= right; k++)
                    {
                        if ((i != j) && (j != k) && (i != k) && (i * i + j * j == k * k))
                        {
                            Console.WriteLine($"({i},{j},{k})");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            GetABC();
        }
    }
}

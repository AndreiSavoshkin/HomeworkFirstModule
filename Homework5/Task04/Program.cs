using System;

namespace Task04
{
    class Program
    {
        static long[] GetArray(int N)
        {
            long[] array = new long[N];
            array[0] = 1;
            array[1] = 1;
            for (var i = 2; i < N; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array;
        }
        static void Main(string[] args)
        {
            do
            {
                int N;
                do Console.WriteLine($"Input N");
                while (!int.TryParse(Console.ReadLine(), out N) || N <= 1 || N >= 93);
                long[] array = GetArray(N);
                for (var i = N -1 ; i >= 0 ; i--)
                {
                    Console.Write($"{array[i]}\t");
                    if ((N - i) % 5 == 0)
                    {
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

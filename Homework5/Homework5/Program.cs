using System;

namespace Homework5
{
    class Program
    {
        static ulong[] GetArray(uint n)
        {
            ulong[] array = new ulong[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = (ulong)Math.Pow(2,i);
            }
            return array;
        }
        static void Main(string[] args)
        {
            do
            {
                uint inputN;
                do Console.WriteLine("Input n");
                while (!uint.TryParse(Console.ReadLine(), out inputN) || inputN == 0 || Math.Pow(2,inputN) > ulong.MaxValue);
                ulong[] array = GetArray(inputN);
                for (var i = 0; i < inputN; i++)
                {
                    Console.Write($"{array[i]}\t");
                    if ((i + 1) % 5 == 0)
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

using System;

namespace Task02
{
    class Program
    {
        static int[] GetArray(uint n)
        {
            uint numElem = n / 2;
            int[] array = new int[numElem];
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    array[count++] = i;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            do
            {
                uint inputN;
                do Console.WriteLine("Input n");
                while (!uint.TryParse(Console.ReadLine(), out inputN) || inputN == 0);
                int[] array = GetArray(inputN);
                for (var i = 0; i < array.Length; i++)
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

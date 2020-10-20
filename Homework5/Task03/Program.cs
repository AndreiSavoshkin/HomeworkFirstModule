using System;
/*
 * Пользователем с клавиатуры вводятся целые числа N > 1, A и D. 
 * В программе сформировать и вывести на экран целочисленный массив из N элементов. 
 * Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D. 
 * Формирование массива организовать при помощи метода.

 */
namespace Task03
{
    class Program
    {
        static int GetInput(string s)
        {
            int x;
            do Console.WriteLine($"Input {s}");
            while (!int.TryParse(Console.ReadLine(), out x));
            return x;
        }

        static int[] GetArray(int N, int A, int D)
        {
            int[] array = new int[N];
            for (var i = 0; i < N; i++)
            {
                array[i] = A + D * i;
            }
            return array;
        }
        static void Main(string[] args)
        {
            do
            {
                int N, A, D;
                do N = GetInput("N");
                while (N <= 1);
                A = GetInput("A");
                D = GetInput("D");
                int[] array = GetArray(N, A, D);
                for (var i = 0; i < N; i++)
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

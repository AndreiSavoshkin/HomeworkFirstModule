﻿using System;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumbers;
            string[] arrayIn;
            CreateArray(out amountOfNumbers, out arrayIn);
            const string input = "input.txt", output = "output.txt";
            try
            {
                File.WriteAllLines(input, arrayIn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Что-то не так: " + ex);
                return;
            }
            string[] arrayOut = new string[amountOfNumbers];
            try
            {
                arrayIn = File.ReadAllLines(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ой, " + ex);
                return;
            }
            for (var i = 0; i < amountOfNumbers; i++)
            {
                if (int.TryParse(arrayIn[i], out _))
                {
                    arrayOut[i] = GetNumberTwo(int.Parse(arrayIn[i])).ToString();
                }
                else
                {
                    Console.WriteLine("Это не числа, а что-то странное");
                    return;
                }
            }
            WriteOutputArray(output, arrayOut);
        }

        private static void WriteOutputArray(string output, string[] arrayOut)
        {
            try
            {
                File.WriteAllLines(output, arrayOut);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Проблемки, " + ex);
                return;
            }
        }

        private static void CreateArray(out int n, out string[] arrayA)
        {
            int left = 0, right = 1001;
            n = 20;
            Random rnd = new Random();
            arrayA = new string[n];
            for (var i = 0; i < n; i++)
            {
                arrayA[i] = rnd.Next(left, right).ToString();
            }
        }
        static int GetNumberTwo (int n)
        {
            int x = 1;
            while (x * 2 < n)
            {
                x *= 2;
            }
            return x;
        }
    }
}

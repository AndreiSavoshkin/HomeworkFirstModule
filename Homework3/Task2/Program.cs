using System;

namespace Task2
{
    class Program
    {
        static int GetAmountDigit(int number)
        {
            var count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }
        static int ReverseNumber(int number)
        {
            var revNumber = 0;
            int count = GetAmountDigit(number) - 1;
            while (number > 0)
            {
                revNumber += (number % 10) * (int)Math.Pow(10, count--);
                number /= 10;
            }
            return revNumber;
        }
        static void Main(string[] args)
        {
            int inputNumber;
            do
            {
                Console.WriteLine("Введите число:");
            }
            while (!int.TryParse(Console.ReadLine(), out inputNumber));
            Console.WriteLine(ReverseNumber(inputNumber));
        }
    }
}

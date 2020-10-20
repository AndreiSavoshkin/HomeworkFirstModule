using System;

namespace Task02
{
    class Program
    {
        static void GetInputThing()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sumNegative = 0, genSum = 0, count = 0;
            do
            {
                Console.WriteLine("Для выхода нажмите ESC, для продолжения любую другую");
                if (inputNumber < 0)
                {
                    sumNegative += inputNumber;
                }
                genSum += inputNumber;
                count++;
                inputNumber = int.Parse(Console.ReadLine());
            }
            while (sumNegative >= -100 && Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine($"Mean {(double)genSum / inputNumber : f3}");
        }
        static void Main(string[] args)
        {
            // I'm sorry for that name. I need more imagination...
            GetInputThing();
        }
    }
}

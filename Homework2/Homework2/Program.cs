using System;

namespace Seminar2
{
    class Program
    {
        static void Main()
        {
            do
            {
                uint numberInput;
                do
                {
                    Console.WriteLine("Input integer value");
                }
                //continues reading until the input data is int
                while (!uint.TryParse(Console.ReadLine(), out numberInput));

                Console.WriteLine("Для выхода из программы нажмите Esc.");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}

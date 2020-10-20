//displays person's first name
using System;

namespace ForrellTask02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"First name: {name}");
            Console.ReadLine();
        }
    }
}

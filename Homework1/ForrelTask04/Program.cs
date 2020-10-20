//displays person's first name
using System;

namespace ForrelTask04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"First name: {name}");
        }
    }
}

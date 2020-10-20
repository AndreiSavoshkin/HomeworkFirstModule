/*displays a person’s full name, street address, and city 
and state on three separate lines on the screen.*/
using System;

namespace ForrellTask05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your full name?");
            string name = Console.ReadLine();
            Console.WriteLine("Which state are you from?");
            string state = Console.ReadLine();
            Console.WriteLine("Which city are you from?");
            string city = Console.ReadLine();
            Console.WriteLine("What's your street?");
            string street = Console.ReadLine();
            Console.WriteLine($"Full name: {name}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Street: {street}");
            Console.ReadLine();
        }
    }
}

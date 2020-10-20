//Вывести три слова с ! вместо разделителя
using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите три слова:");
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();
            string wordThree = Console.ReadLine();
            Console.WriteLine($"{wordOne}!{wordTwo}!{wordThree}");
            Console.ReadLine();
        }
    }
}

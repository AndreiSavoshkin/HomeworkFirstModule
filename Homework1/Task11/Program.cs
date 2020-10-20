//Вывести три слова, поставив с двух сторон -
using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите три слова:");
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();
            string wordThree = Console.ReadLine();
            Console.WriteLine($"-{wordOne}-");
            Console.WriteLine($"-{wordTwo}-");
            Console.WriteLine($"-{wordThree}-");
            Console.ReadLine();
        }
    }
}

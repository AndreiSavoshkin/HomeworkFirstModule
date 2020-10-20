//вывести символ по значению в ASCII
using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //the correctness of input data
            Console.WriteLine("Введите число от 32 до 127");
            string input = Console.ReadLine();
            int Code = int.Parse(input);
            //searching a symbol using char
            char charCode = (char)Code; 
            Console.WriteLine(charCode);
            Console.ReadLine();
        }
    }
}

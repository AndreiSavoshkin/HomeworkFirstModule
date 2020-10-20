using System;
using System.IO;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"../../../../intNumber.txt"))
            {
                Console.WriteLine("Файла не существует.");
                Console.ReadLine();
                return;
            }
            int binaryNumberInt;
            string binaryNumberString;
            try
            {
                binaryNumberString = File.ReadAllText("../../../../intNumber.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            if (!int.TryParse(binaryNumberString, out binaryNumberInt))
            {
                Console.WriteLine("This is not a number!!!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(Convert.ToInt32(binaryNumberString, 2));
            Console.WriteLine(binaryNumberString);
            Console.ReadLine();
        }
    }
}


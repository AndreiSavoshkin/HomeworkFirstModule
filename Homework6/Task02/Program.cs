using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Введите число: ");
        do Console.WriteLine("Input positive number");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
        string binaryNumberString = Convert.ToString(n, 2).PadLeft(32, '0');
        try
        {
            File.WriteAllText(@"../../../../intNumber.txt", binaryNumberString);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            return;
        }
    }
}



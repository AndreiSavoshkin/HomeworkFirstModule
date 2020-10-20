using System;
using System.IO;

namespace Task03
{
    class Writer
    {
        static void Main(string[] args)
        {
            int n;
            string filePath = "../../../../Numbers.bin";
            int bytesInInt = 4;
            do Console.WriteLine("Input n");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10);
            byte[] bytes = new byte[(n - 1) * bytesInInt];
            for (int i = 1; i < n; i++)
            {
                byte[] numberBytes = BitConverter.GetBytes(i);
                Array.Copy(numberBytes, 0, bytes, (i - 1) * bytesInInt, bytesInInt);
            }
            WriteFile(filePath, bytes);
        }

        private static void WriteFile(string filePath, byte[] bytes)
        {
            try
            {
                File.WriteAllBytes(filePath, bytes);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when creating or writing to the file: {e.Message}");
            }
        }
    }
}
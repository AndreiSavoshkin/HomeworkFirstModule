using System;
using System.IO;

namespace Task032
{
    class Reader
    {
        static void Main(string[] args)
        {
            byte[] bytes = new byte[0];
            int bytesInInt = 4;
            string path = Path.PathSeparator;
            string filePath = "../../../../Numbers.bin";
            bytes = ReadFile(filePath);
            for (int i = 0; i < bytes.Length / bytesInInt; i++)
            {
                Console.WriteLine(BitConverter.ToInt32(bytes, i * bytesInInt));
            }
        }
        static byte[] ReadFile(string filePath)
        {
            try
            {
                return File.ReadAllBytes(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error while reading from file: {e.Message}");
                return null;
            }
        }
    }

}

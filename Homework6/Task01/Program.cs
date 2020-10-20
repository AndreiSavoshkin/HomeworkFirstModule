using System;
using System.IO;
using System.Text;

namespace Directories
{
    class Program
    {
        static string DirectoryOverview(string path)
        {
            StringBuilder nullDirect = new StringBuilder();
            var directories = Directory.GetDirectories(path);
            for (int i = 0; i < directories.Length; i++)
            {
                var directory = directories[i];
                var directoryInfo = new DirectoryInfo(directory);
                Console.WriteLine($"{directory}\n" +
                $"attributes: {directoryInfo.Attributes}; " +
                $"creation time: {directoryInfo.CreationTime} " +
                $"last update:{directoryInfo.LastWriteTime}\n");
                if (Directory.GetDirectories(directory).Length + Directory.GetFiles(directory).Length == 0)
                {
                    nullDirect.Append(directory + Environment.NewLine);
                    Directory.Delete(directory);
                }
                else
                {
                    DirectoryOverview(directory);
                }
            }
            return nullDirect.ToString();
        }
        static void Main(string[] args)
        {
            int k,n;
            string nullDirect;
            do Console.WriteLine($"1 - all directories{Environment.NewLine}2 - concrete directory");
            while (!int.TryParse(Console.ReadLine(), out n));
            if (n == 1)
            {
                do Console.WriteLine("input k");
                while (!int.TryParse(Console.ReadLine(), out k));
                string path = new string(' ', k).Replace(" ", @"..\");
                try
                {
                    nullDirect = DirectoryOverview(path);
                    Console.WriteLine($"Пустые папки:{Environment.NewLine}{nullDirect}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Произошла ошибка ввода/вывода: {ex.Message}");
                }
                catch (System.Security.SecurityException ex)
                {
                    Console.WriteLine($"Произошла ошибка безопасности: {ex.Message}");
                }
                Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
                Console.ReadLine();
            }
            else if (n == 2)
            {
                Console.WriteLine("Input path");
                string path = Console.ReadLine();
                try
                {
                    nullDirect = DirectoryOverview(path);
                    Console.WriteLine($"Пустые папки:{Environment.NewLine}{nullDirect}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Произошла ошибка ввода/вывода: {ex.Message}");
                }
                catch (System.Security.SecurityException ex)
                {
                    Console.WriteLine($"Произошла ошибка безопасности: {ex.Message}");
                }
                Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
                Console.ReadLine();
            }
        }
    }
}


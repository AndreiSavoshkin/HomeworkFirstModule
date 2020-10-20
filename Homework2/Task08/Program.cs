/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
*/
using System;

namespace Task07
{
    class Program
    {
        //класс для нахождения наибольшего числа
        public static void ValuesMax(ref int n)
        {
            // Вспомогательные переменные
            int a1 = 0, a2 = 0, a3 = 0;
            int x = n / 100,
                y = n / 10 % 10,
                z = n % 10;
            a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
            a2 = x < y ? (x > z ? x : (z < y ? z : y)) : (x < z ? z : (z < y ? y : z));
            a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
            n = 100 * a3 + 10 * a2 + a1;
        }

        public static void Main(string[] args)
        {
            do
            {

                int x = 0;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите трехзначное числе");
                    str = Console.ReadLine();
                }
                while (!int.TryParse(str, out x));
                if (99 < x && x < 1000)
                {
                    ValuesMax(ref x);
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Это не трехзначное число!");
                }
                Console.WriteLine("Для выхода нажмите ESC");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}


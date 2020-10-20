/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
Задача на применение тернарной операции. 
Написать метод, так обменивающий значения трех переменных x, y, z, чтобы выполнилось требование: x <= y <= z. 
В основной программе, вводить значения трех переменных и упорядочивать их с помощью обращения к написанному методу. 
Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу. 
*/

using System;
class Program
{
    public static void ValuesSort(ref int x, ref int y, ref int z)
    {
        // Вспомогательные переменные
        int a1 = 0, a2 = 0, a3 = 0;
        a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
        a2 = x < y ? (x > z ? x : (z < y ? z : y)) : (x < z ? z : (z < y ? y : z));
        a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
        x = a1; y = a2; z = a3;
    }

    public static void Main()
    {
        do
        {

            int x = 0, y = 0, z = 0;
            string str;    // Строка для приёма данных
            do
            {
                Console.WriteLine("Введите значение x");
                str = Console.ReadLine();
            }
            while (!int.TryParse(str, out x));
            do
            {
                Console.WriteLine("Введите значение y");
                str = Console.ReadLine();
            }
            while (!int.TryParse(str, out y));
            do
            {
                Console.WriteLine("Введите значение z");
                str = Console.ReadLine();
            }
            while (!int.TryParse(str, out z));
            ValuesSort(ref x,ref y,ref z);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("Для выхода из программы нажмите Esc.");
        }
        //comparing to Escape
        while (!(Console.ReadKey().Key == ConsoleKey.Escape));
    } 
} 


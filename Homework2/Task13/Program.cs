/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
*/
using System;

namespace Task12
{
    class Program
    {
        public static string IntegerAndFractionalPartsNumber(double x)
        {
            int integerX = (int)x;
            return $"Целая часть числа {integerX:G}{Environment.NewLine}дробная часть числа {(x - Math.Truncate(x)):G}";
        }
        public static string RootAndSquareNumber(double x)
        {
            if (x < 0)
            {
                return $"Не может быть извлечен квадратный корень{Environment.NewLine}квадрат числа равен {(x * x):F3)}";
            }
            else
            {
                return $"Квадратный корень из числа равен {Math.Sqrt(x):F3}{Environment.NewLine}квадрат числа равен {x * x:F3}";
            }
        }
        
        public static void Main()
        {
            do
            {
                double numberInput;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите число");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out numberInput));

                Console.WriteLine(IntegerAndFractionalPartsNumber(numberInput));
                Console.WriteLine(RootAndSquareNumber(numberInput));
                Console.WriteLine("Для выхода нажмите ESC");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}

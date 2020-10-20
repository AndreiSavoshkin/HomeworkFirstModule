/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
*/
using System;
using System.Globalization;

namespace Task12
{
    class Program
    {
        public static string CountMoneyForComputer(int percent, double budget)
        {
            return "Ваш бюджет на компьютер " + (budget * percent / 100).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }

        public static void Main(string[] args)
        {
            do
            {

                int percent = 0;
                double budget = 0;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите значение бюджета");
                    str = Console.ReadLine();
                }
                while (!double.TryParse(str, out budget));
                do
                {
                    Console.WriteLine("Введите значение процент бюджета");
                    str = Console.ReadLine();
                }
                while (!int.TryParse(str, out percent));

                Console.WriteLine(CountMoneyForComputer(percent,budget));
                Console.WriteLine("Для выхода нажмите ESC");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}

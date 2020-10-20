/*   Дисциплина: "Программирование"
     Группа:      БПИ208(2)
     Студент:     Савочкин Андрей Игоревич 
     Дата:        2020.09.22 
Задан круг с центром в начале координат и радиусом R=10.   
Ввести  координаты точки и вывести сообщение:   «Точка внутри круга!» или «Точка вне круга!».
Предусмотреть проверку входных данных и цикл повторения решений.  
*/

using System;

namespace Task06
{
    class Program
    {
        public static string CheckPlaceInOutCircle(int x, int y)
        {
            int R = 10;
            string result = x * x + y * y < R * R ? "Точка внутри круга!" : "Точкна вне круга!";
            return result;
        }
        public static void Main(string[] args)
        {
            do
            {

                int x = 0, y = 0;
                string str;    // Строка для приёма данных
                do
                {
                    Console.WriteLine("Введите значение координаты x");
                    str = Console.ReadLine();
                }
                while (!int.TryParse(str, out x));
                do
                {
                    Console.WriteLine("Введите значение координаты y");
                    str = Console.ReadLine();
                }
                while (!int.TryParse(str, out y));
                Console.WriteLine(CheckPlaceInOutCircle(x, y));
                Console.WriteLine("Для выхода нажмите ESC");
            }
            //comparing to Escape
            while (!(Console.ReadKey().Key == ConsoleKey.Escape));
        }
    }
}

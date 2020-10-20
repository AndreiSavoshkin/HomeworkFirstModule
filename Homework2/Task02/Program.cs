/*
   Дисциплина: "Программирование"
   Группа:      БПИ208(2)
   Студент:     Савочкин Андрей Игоревич
   Задача:      Написать метод для вычисления площади и длины окружности, радиус которой задает вещественный параметр. 
    В основной программе, вводя значения радиуса, с помощью обращения к методу, вычислять площадь и длину окружности. 
    При вводе применять метод double.TryParse() и проверять корректность введенного значения. При выводе использовать 
    форматную строку метода WriteLine(). Окончание работы программы – ввод нулевого или отрицательного значения радиуса.    
     Дата:        2020.09.22
*/

using System;
class MyExample
{
    public static double GetSquare(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double GetLength(double radius)
    {
        return 2 * Math.PI * radius;
    }
    public static void Main()
    {
        double r, //радиус
               s, // площадь круга
               c;  // длина окружности        
        string str;       // Рабочая строка для ввода и вывода данных 
        do
        {
            do
            {
                Console.Write("Введите радиус: ");
                str = Console.ReadLine();         //Читаем символьную строку
            } while (!double.TryParse(str, out r)); // Преобразуем в число
            if (r > 0)
            {
                s = GetSquare(r);
                c = GetLength(r);
                str = "Площадь окружности: " + s.ToString("F3") + " Длина окружности: " + c.ToString("F3");
                Console.WriteLine(str);
                Console.WriteLine("Для окончания программы введите неположительный радиус.");
            }
        }
        while (r > 0);
    } 
} 


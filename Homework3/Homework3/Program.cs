using System;

namespace Task01
{
    class Program
    {
        static bool CheckEqualNumber(int n)
        {
            bool flag = true;
            while (n > 0)
            {
                if (n % 10 != n / 10 % 10)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static void GetNumberAndSum()
        {
            var number = 0;
            var count = 1;
            while (((number < 100) || (number > 999) && !CheckEqualNumber(number)))
            {
                number += count++;
            }
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            GetNumberAndSum();
        }
    }
}

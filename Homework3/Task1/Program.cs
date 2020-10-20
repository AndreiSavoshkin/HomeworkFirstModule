using System;

namespace Task01
{
    class Program
    {
        static bool CheckEqualNumber(int n)
        {
            bool flag = true;
            while (n > 10)
            {
                if (n % 10 != n / 10 % 10)
                {
                    flag = false;
                    break;
                }
                n /= 10;
            }
            return flag;
        }
        static void GetNumberAndSum()
        {
            var number = 0;
            var count = 1;
            while (!((number > 100) && (number < 1000) && CheckEqualNumber(number)))
            {
                number += count++;
            }
            Console.WriteLine(number);
            Console.WriteLine($"s = 1 + 2 + 3 + ... + {count - 2} + {count - 1} + {count}.");
        }
        static void Main()
        {
            GetNumberAndSum();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class IsPrime
    {
        public static bool IsPrimeNum(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i==0)
                {
                    count++;
                }
            }
            return count == 2;
        }
        static void Main(string[] args)
        {
            IsPrimeNum(5);
        }
    }
}

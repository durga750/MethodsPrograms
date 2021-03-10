using System;
using System.Collections.Generic;
using System.Text;

namespace AllMethods
{
    class CountFactors
    {
        public static void Factors(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++; 
                }

            }
            Console.WriteLine($"count is:" + count);
        }

        static void Main(string[] args)
        {
            Factors(12);
        }
    }
}

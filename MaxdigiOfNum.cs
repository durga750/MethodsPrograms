using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MaxdigiOfNum
    {
        public static int Maxdigit(int num)
        {
            int max = num%10;
            while(num>0)
            {
                int digit = num % 10;

                if (max < digit)
                {
                    max = digit;
                }
                num /= 10;
            }
           
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Maxdigit(3864));
        }
    }
}

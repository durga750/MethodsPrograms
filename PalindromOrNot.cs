using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class PalindromOrNot
    {
        public static bool IsPalindrom(int num)
        {
            int copy = num;
            int rev = 0;
            while(num>0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }

            return copy==rev ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrom(121));
        }
    }
}

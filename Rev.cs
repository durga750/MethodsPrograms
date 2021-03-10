
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Rev
    {
        public static string ReverseOfNum(int num)
        {
            string rev = string.Empty;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev  + digit+ "\t";
                num /= 10;
            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOfNum(12345));
        }
    }
}

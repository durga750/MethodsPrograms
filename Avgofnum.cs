using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Avgofnum
    {
        public static int AvgOfnum(int num)
        {
            int avg = 0, count = 0, sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                sum = sum + digit;
                avg = sum / count;
                num /= 10;
            }
           
            Console.WriteLine(avg);
            return avg;
        }
        static void Main(string[] args)
        {
            AvgOfnum(234);
        }
    }
}

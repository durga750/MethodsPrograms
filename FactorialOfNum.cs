
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class FactorialOfNum
    {
        public static int Factorial(int num)
        {
            int fact = 1;
            for (int i = num; i > 1; i--)
            {
                fact = fact * i;
            }

            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
        }
    }
}

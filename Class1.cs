using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
  
    class Class1
    {
        public static void GenNum(int start, int end)
        {
            Console.WriteLine("ascending order");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("descending order");
            for (int i = end; i >=start; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("sum of numbers in given range");
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"sum is:"+sum);
        }
        static void Main(string[] args)
        {
            GenNum(1, 5);
        }
    }
}

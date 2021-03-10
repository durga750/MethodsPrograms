using System;
using System.Collections.Generic;
using System.Text;

namespace AllMethods
{
    class IsPerfectnum
    {
        public static bool IsperfectNum(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if(num%i==0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsperfectNum(12));
        }
    }
}

using System;

namespace AllMethods
{
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrimeNum(4));
        }

        public static bool IsPrimeNum(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count == 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meth
{
    class IsPer
    {
        public static bool IsperfectNum(int num)
        {
            int sum = 0;
            int copy = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                  }
            }
            return  copy==sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsperfectNum(6));
        }
    }
}

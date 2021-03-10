using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Separatedigits
    {
        static void Main(string[] args)
        {
            //Digits(345);
            //BasicUserPro.Digit(122234);
            Console.WriteLine(Digit(345));
        }

      /*  public static void Digits(int num)
        {
            
            while(num>0)
            {
                int digit = num % 10;
                Console.WriteLine(digit);
                num /= 10; 
            }
          
        }    */

        public static string Digit(int num)
        {
            string str = string.Empty;
            while(num>0)
            {
                int digit = num % 10;
                str = str + digit + "\n";
                num /= 10;
            }
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class NumberOfDigitsInANumber
    {
        static int count=0;
        public static void NumDigits(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Console.WriteLine(++count);
            NumDigits(n/10);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class SumOfDigitsInaNumber
    {
        private static int sum = 0;
        public static void SumOfDigits(int n)
        {
            if (n <= 0)
            {
                return;
            }

            sum += n%10;
            Console.WriteLine(sum);
            SumOfDigits(n/10) ;
        }
    }
}

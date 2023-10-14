using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    public class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            var d= isRecur(n, n);
            return d;
        }
        public static bool isRecur(int n,int temp)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += (n % 10) * (n % 10);
                n = n / 10;
                Console.WriteLine(" sum   " + sum + " n  " + n);
            }
            if (sum == 1)
            {

                return true;
            }
            else if (sum == temp)
            {
                return false;
            }
            return isRecur(sum, temp); 
        }
    }
}

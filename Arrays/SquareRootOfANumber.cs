using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class SquareRootOfANumber
    {
        private static int num = 24;
        public static void SquareRoot()
        {
            int n = num / 2;
            int start = 1;
            int end = n;
            int mid;
            int res = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (mid * mid == num)
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (mid * mid < num) {
                    start = mid + 1;
                    res = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            Console.WriteLine(res);
        }
    }
}

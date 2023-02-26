using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class reverseAnumber
    {
        public static int Reverse(int x)
        {
            if(x > Int32.MaxValue)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                int rem = 0;
                
                while (x != 0)
                {
                    rem = x % 10;
                    Int64 sum1=sum;
                    sum1 = sum1 * 10;
                    if (sum1 > Int32.MaxValue)
                    {
                        return 0;
                    }
                    sum = sum * 10 + rem;
                    x = x / 10;
                    
                }
                Console.WriteLine(sum);
                return sum;
            }

        }
    }
}

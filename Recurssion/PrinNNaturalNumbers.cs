using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class PrinNNaturalNumbers
    {
        public static void NaturalNumbers(int n)
        {
            Console.WriteLine(n);

            if (n < 0)
            {
                return;
            }
            NaturalNumbers(n-1);
            Console.WriteLine(n);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    internal static class FactorialNumber
    {
        public static int fact(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return n*fact(n-1);
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal static class balancedParanthesis
    {
        public static void balance(int i,int o,int c, char[] arr,int n)
        {
            if(i==arr.Length)
            {
                Console.WriteLine(arr);
                return;
            }
            if (o < n)
            {
                arr[i] = '(';
                balance(i + 1, o + 1, c, arr,n);
            }
            if (c < o)
            {
                arr[i] = ')';
                balance(i + 1, o, c + 1, arr,n);
            }
        }
    }
}

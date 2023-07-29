using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public class BalanacedParanthesis
    {
        public static void Balance(int n,int i,int c,int o, char[] arr)
        {
            if(i==arr.Length)
            {
                Console.WriteLine(arr);
            }
            if (o < n)
            {
                arr[i] = '(';
                Balance(n,i+1,c,o+1,arr);
            }
            if (c < o)
            {
                arr[i] = ')';
                Balance(n,i+1,c+1,o,arr);
            }
        }
    }
}

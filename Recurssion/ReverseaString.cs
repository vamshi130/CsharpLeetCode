using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class ReverseaString
    {
        private static string str = "vamshi";
        private static int n = str.Length;
        public static void StringReverse(int i)
        {
            if (i <= 0) return;
            Console.WriteLine(str[n - 1]);
            StringReverse(--n);
        }
        public static void CheckPalindrome(string str, int n, int k)
        {
            if (k <= n / 2)
            {
                if (str[k] != str[n - k - 1])
                {
                    Console.WriteLine("Not a palindrome");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Palindrome");
                return;
            }
            CheckPalindrome(str,n,k+1);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class palindromeInaString
    {
        static string max = "";
        public static string LongestPalindrome()
        {
            string s = "cbbd";
            var len = s.Length;
            List<string> list = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <len+1; j++)
                {
                    list.Add(s.Substring(i, j));
                }
                len--;
                
            }
            foreach(var li in list)
            {
                CheckPalindrome(li);
            }

            Console.WriteLine(max);
            return null;

        }
        public static string CheckPalindrome(string list)
        {
            for (int i = 0; i < (list.Length) / 2; i++)
            {
                if (list[i] != list[list.Length - i-1])
                {
                    
                    return null;
                }

            }
            if (max.Length > list.Length)
            {
                return max;
            }
            else
            {
                max = list;
                return max;
            }
            Console.WriteLine(list);
            return null;
        }
    }
}

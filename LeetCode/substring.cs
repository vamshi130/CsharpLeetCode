using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public  class substring
    {
        public static int LengthOfLongestSubstring()
        {
            string s = "abccbcbbdefgh";
            int max = 0;
            string test = "";
            foreach(var c in s.ToCharArray())
            {
                var current = c + "";
                if (test.Contains(c))
                {
                    test=test.Substring(test.IndexOf(current)+1);
                }
                test += c;
                max=Math.Max(max,test.Length);
            }
            Console.WriteLine(max); 
            return max;
        }
    }
}

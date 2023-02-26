using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class palindrome
    {
        public static Boolean palindromes(int x)
        {
            long upperBound = (long)Math.Pow(2, 31) - 1;
            long lowerBound = -(long)Math.Pow(2, 31);

            if (x < 0)
            {
                return false;
            }
            StringBuilder sb = new StringBuilder();
            string str=x.ToString();
            char[] ch = str.ToCharArray(); 
            for (int i = (ch.Length) - 1; i >= 0; i--)
            {
                sb.Append(ch[i]);
            }
            var sd = Int64.Parse(sb.ToString());
            if (x == sd)
            {
                if ((-sd) < lowerBound && sd > upperBound)
                {
                    return false;

                }
                return true;
            }
            return false ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class FindNumInString
    {
        public static int number(string str)
        {
            long upperBound = (long)Math.Pow(2, 31) - 1;
            long lowerBound = -(long)Math.Pow(2, 31);
            str = str.Trim();
            StringBuilder sb = new StringBuilder();
            
            var isposi = true;
            if (str[0] == '-')
            {
                isposi = false;
            }
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == '-')
                {
                    i++;
                    continue;
                }
                else if (!char.IsDigit(str[i]))
                {
                    break;
                }
                else if (char.IsDigit(str[i])){
                    sb.Append(str[i]);
                }
                i++;
            }
           
            if (sb.Length < 1 )
            {
                return 0;
            }
            Int64 sd = int.Parse(sb.ToString());
            if ((-sd) < lowerBound && sd > upperBound)
            {
                return 0;

            }
            if (!isposi)
            {
                return -(int.Parse(sb.ToString()));
            }
            return int.Parse(sb.ToString());









            //var isPos = true;
            //StringBuilder sb = new StringBuilder();
            //char[] ch = str.ToCharArray();
            //for (int i = 0; i < ch.Length; i++) {
            //    if (ch[i] == '-') {
            //        isPos = false;
            //    }
            //    if (char.IsDigit(ch[i])) {
            //        sb.Append(ch[i]);
            //    }
            //}
            //Int64 sd = int.Parse(sb.ToString());
            //if ((-sd) < lowerBound && sd > upperBound)
            //{
            //    return 0;

            //}
            //if ((!char.IsDigit(ch[0])) || ch[0]!='-' )
            //{
            //    return 0;
            //}
            //if (!isPos)
            //{
            //    return -(int.Parse(sb.ToString()));
            //}
            //return int.Parse(sb.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class SubsequenceInAString
    {
        public static void SubSequence(string str, string ans)
        {
            if(str.Length == 0)
            {
                Console.WriteLine(ans);
                return;
            }
            SubSequence(str.Substring(1), ans + str[0]);
            SubSequence(str.Substring(1), ans);

        }
    }
}

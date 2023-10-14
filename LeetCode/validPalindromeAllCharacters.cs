using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class validPalindromeAllCharacters
    {
        public static Boolean ValidatePalindrome()
        {
            string s = "Noel - sees Leon";
            string su = " ";
            //if(string.IsNullOrEmpty(s)) {
            //    Console.Write(true);
            //    return true;
            //}
            if(s.Length < 1) {
                return true;
            }
            for(int i=0;i<s.Length; i++)
            {
                if (char.IsLetter(s[i]) || char.IsDigit(s[i]))
                {
                    su = su + s[i];
                }
            }
            su=su.ToLower();
            for(int i = 0; i < (su.Length)/2; i++)
            {
                if (su[i] != su[su.Length - i - 1])
                {
                    return false;
                }
            }
            Console.WriteLine(su);
            return true;
        }
    }
}

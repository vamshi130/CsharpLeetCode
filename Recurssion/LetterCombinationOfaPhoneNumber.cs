using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class LetterCombinationOfaPhoneNumber
    {
        public static void LetterCombination(string str, string ans)
        {
            if(str.Length == 0) { 
                Console.WriteLine(ans); return; }
            string[] keypad = new string[] { "" ,"abc", "bcd", "cef", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            Console.WriteLine((str[0] -48));
            var key = keypad[str[0] - 48];
            for(int i=0;i<key.Length;i++)
            {
                LetterCombination(str.Substring(1), ans + key[i]);
            }
        }
    }
}

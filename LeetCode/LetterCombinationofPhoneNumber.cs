using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class LetterCombinationofPhoneNumber
    {
        public static IList<string> LetterCombinations()
        {
            string digits = "2";
            var list=new List<string>();
            var dict=new Dictionary<int, string>();
            dict.Add(2, "abc");
            dict.Add(3, "def");
            dict.Add(4, "efg");
            dict.Add(5, "hij");
            var sb=new StringBuilder();
            if (digits.Length == 1)
            {
                var str1 = dict[int.Parse(digits)].ToCharArray();
            }
            else
            {
                for(int i=0;i<digits.Length;i++)
                {
                    
                }
            }
            var str=dict[2].ToString();
            Console.WriteLine(str); 

            return null;
        }
    }
}

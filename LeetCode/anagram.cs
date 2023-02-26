using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class anagram
    {
        public static bool anagramCheck(string s,string t)
        {
            s = s.ToLower();
            t = t.ToLower();
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            Array.Sort(s1);
            Array.Sort(t1);
            Console.WriteLine(s1);

            if (s.Length != t.Length)
            {
                Console.WriteLine("false");
                return false;
            }
            string s2 = new string(s1);
            string t2 = new string(t1);
            if (s2 == t2)
            {
                Console.WriteLine("true"+s2+"rte");
                return true;
            }
            Console.WriteLine("false");
            return false;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!t.Contains(s[i]))
            //    {
            //        Console.WriteLine("false");
            //        return false;
            //    }
            //}
            //Console.WriteLine("true");
            //return true;
        }
    }
}

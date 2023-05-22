using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public static class AllPermutationsOfaString
    {
        public static string permutations(char[] chars,int fi)
        {
            if (chars.Length-1  == fi)
            {
                Console.WriteLine(chars);
                return null;
            }
            for(int i = fi; i < chars.Length; i++)
            {
                swap(i,fi,chars);
                permutations(chars, fi + 1);
                swap(i, fi, chars);
            }
            return null;
        }
        public static void swap(int i,int fi, char[] chars)
        {
            char temp= chars[i];
            chars[i]= chars[fi];
            chars[fi]= temp;

        }
    }
}

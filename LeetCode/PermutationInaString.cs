using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class PermutationInaString
    {
        static int flag = 0;
        public static bool CheckInclusion(string s1, string s2)
        {

            int fi = 0;
            char[] chars = s1.ToCharArray();
            AllPermutations(chars, fi, s2);
            if (flag == 1)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }

        }
        public static bool AllPermutations(char[] chars, int fi, string str1)
        {
            if (fi == chars.Length - 1)
            {
                string st = new string(chars);
                if (str1.Contains(st))
                {
                    flag = 1;
                }
                return false;
            }
            for (int i = fi; i < chars.Length; i++)
            {
                swap(chars, i, fi);
                AllPermutations(chars, fi + 1, str1);
                swap(chars, i, fi);
            }
            return true;
        }
        public static void swap(char[] chars, int i, int fi)
        {
            char temp = chars[i];
            chars[i] = chars[fi];
            chars[fi] = temp;
        }
        //  static int flag = 0;
        //  public static bool Permutation()
        //  {

        //      string str1 = "eidboaoo";
        //      string str = "ab";
        //      int fi = 0;
        //      char[] chars= str.ToCharArray();
        //      AllPermutations(chars,fi,str1);
        //      if(flag== 1) {
        //          Console.WriteLine("true");
        //          return true;
        //      }
        //      else
        //      {
        //          return false;
        //      }
        //  }
        // public static bool AllPermutations(char[] chars,int fi,string str1)
        //  {
        //      if (fi == chars.Length-1)
        //      {
        //          string st = new string(chars);
        //          if (str1.Contains(st))
        //          {
        //              flag= 1;
        //          }
        //          Console.WriteLine(chars);
        //          return false;
        //      }
        //      for(int i = fi; i < chars.Length; i++)
        //      {
        //          swap(chars, i, fi);
        //          AllPermutations(chars,fi+1,str1);
        //          swap(chars, i, fi);
        //      }
        //      return true;
        //  }
        //public static void swap(char[] chars,int i,int fi)
        //  {
        //      char temp = chars[i];
        //      chars[i] = chars[fi];
        //      chars[fi] = temp;
        //  }

    }
}

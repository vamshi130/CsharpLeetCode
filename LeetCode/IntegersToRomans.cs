using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class IntegersToRomans
    {
        public static string romans(int num)
        {
            int[] values = { 1000,   900, 500,  400, 100,  90,   50,   40,  10,    9,  5,     4,  1 };
            string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            var dictionary=new Dictionary<string, int>();
            string s= "MCMXV";

            dictionary.Add("M",1000);
            dictionary.Add("D",500);
            dictionary.Add("C", 100);
            dictionary.Add("L", 50);    
            dictionary.Add("X", 10);
            dictionary.Add("V", 5);
            dictionary.Add("I", 1);
            s=s.Replace("CM","DCCCC");
            s=s.Replace("CD", "CCCC");
            s=s.Replace("XC", "LXXXX");
            s=s.Replace("XL","XXXX");
            s=s.Replace("IX", "VIIII");
            s=s.Replace("IV", "IIII");
            int dm=0;
            for (int i = 0; i < s.Length; i++)
            {
                dm += dictionary[s[i].ToString()];
            }

            //var str = new StringBuilder();
            //for (int i = 0; i < values.Length; i++)
            //{
            //    while (num >= values[i])
            //    {
            //        num = num - values[i];
            //        str.Append(romans[i]);
            //    }
            //}
            //return str.ToString();
            string st = "LIVIII";
            int str = 0;
            for (int i = 0; i < values.Length; i++)
            {
                while (st[i].ToString() == romans[i])
                {
                    if(values[i] > values[i + 1])
                    {
                        st+=values[i];
                        i = 0;
                    }


                   
                }
                if (st[i]>st[i+1])
                {

                }
            }
            return str.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class commonStringInArray
    {
        public static string commonString(string[] str)
        {
            int[] arr=new int[3] {1,2,3};
   
            Array.IndexOf(str, "abc");
            string haystack = "mississippi";
            string needle = "issi";
            int i = 0;
            int len = haystack.Length;
            if (haystack.Substring(0, needle.Length) == needle)
            {
                return 0.ToString();
            }
            while (i < len - (needle.Length - 1))
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i.ToString();
                }
                i++;
            }

            //string stri = "vamshi";
            //string st=stri.Substring(0,2);
            //var list = new List<string>();
            //var len = str[0].Length;
            //for (int k = 1; k < len + 1; k++)
            //{
            //    list.Add(str[0].Substring(0, k));
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    var res = str.All(x => x.StartsWith(list[i]));
            //    if (res && stri.Length < list[i].Length)
            //    {
            //        stri = list[i];
            //    }
            //}

            return 0.ToString();
        }
    }
}

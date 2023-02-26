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
          
            if(str.Length == 1)
            {

            }
            string stri = "";
            var list=new List<string>();       
            var len=str[0].Length;
          
            for(int i = 0; i < str[0].Length; i++)
            {
                for (int k = 2; k < len+1; k++) 
                {
                    list.Add(str[0].Substring(i,k));
                }
                len = len - 1;


            }
            for(int i = 0; i < list.Count; i++)
            {
                var res = str.All(x => x.StartsWith(list[i]));
                if (res == true)
                {
                    if(stri.Length < list[i].Length)
                    {
                        stri = list[i];
                    }
                }
            }
            
            return stri;
        }
    }
}

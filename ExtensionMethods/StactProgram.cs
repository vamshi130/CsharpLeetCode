using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class StactProgram
    {
        //here this means we are binding the test method with program class
        public static void Test3(this Program pg)
        {
           
            Console.WriteLine("Test 3 method of static class");
        }
        public static long Factorial(this Int32 i)
        {
            if(i== 0)
            {
                return 0;
            }
            else if(i== 1)
            {
                return 1;
            }
            else if (i == 2)
            {
                return 2;
            }
            return i*Factorial(i-1);
        }
        public static string ToProper(this string oldStr)
        {
            if (oldStr.Trim().Length > 0)
            {
                String newStr =" ";
                //String newStr = null;
                oldStr = oldStr.ToLower();
                string[] strArray = oldStr.Split(' ');
                foreach(string str in strArray)
                {
                    char[] chars = str.ToCharArray();
                    chars[0] = Char.ToUpper(chars[0]);
                    newStr += " " + new string(chars);
                    //if (newStr == null)
                    //{
                    //    newStr = new string(chars);
                    //}
                    //else
                    //    newStr += " " + new string(chars);
                }
                return newStr;

            }
            return oldStr;
        }
    }
}

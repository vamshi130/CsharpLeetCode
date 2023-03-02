using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int addDelegate(int a, int b);
    public delegate string returnDelgate(string str);
    public class delegates
    {
        public static int addNumbers(int a,int b)
        {
            return a + b;
        }
        public string returnName(string str)
        {
            return "hi" + str;
        }
        
    }
}

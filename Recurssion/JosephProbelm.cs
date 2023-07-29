using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class JosephProbelm
    {
        public static int Joseph(int n, int k)
        {
            if (n == 1)
            {
                return 0;
            }
           int result= (Joseph(n - 1, k) + k) % n;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class RopeCutting
    {
        public static int RopeCut(int n,int a,int b,int c)
        {
            int pieces = 0;
            if (n ==0)
            {
                return 0;
            }
            if(n<0)
            {
                return -1;
            }
            int item= RopeCut(n-a, a, b, c);
            int item2=RopeCut(n-b, a, b, c);
            int item3=RopeCut(n-c, a, b, c);
            pieces = Math.Max(item, Math.Max(item2, item3));
            if(pieces == -1 ) { return -1; }
            return pieces += 1;
        }
    }
}

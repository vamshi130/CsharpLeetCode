using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class TappingRainWater
    {
        private static int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        public static void TappingWater() {
            // Using two way pointer approach

            int lbh = height[0];
            int rbh = height[height.Length-1];
            int l = 0;
            int r = height.Length - 1;
            int res = 0;
            while (l<r) {
                if (lbh <= rbh)
                {
                    if (height[l] >= lbh)
                    {
                        lbh = height[l];
                    }
                    else
                    {
                        res += lbh - height[l];
                    }
                    l++;
                }
                else
                {
                    if (height[r] >= rbh)
                    {
                        rbh = height[r];
                    }
                    else { 
                        res += rbh - height[r];
                    }
                    r--;
                }

            }

            // O(n) approcah but having more space complexity
            //int[] lb = new int[height.Length];
            //int[] rb = new int[height.Length];
            //lb[0] = height[0];
            //rb[height.Length - 1] = height[height.Length-1];
            //for (int i = 1; i < height.Length; i++)
            //{
            //    lb[i] = Math.Max(height[i], lb[i - 1]);
            //}
            //for (int i = height.Length-2; i >=0; i--)
            //{
            //    rb[i] = Math.Max(height[i], rb[i + 1]);
            //}
            //int mb = 0;
            //int wt = 0;
            //int res = 0;
            //for (int i = 0; i < height.Length; i++) {
            //    mb = Math.Min(lb[i], rb[i]);
            //    wt = mb - height[i];
            //    res += wt;
            //}


            //O(n2) approach
            //int res = 0;
            //int lb;
            //int rb;
            //int wt = 0;
            //int tw = 0;
            //for (int i = 1; i < height.Length - 1; i++) {
            //    lb = height[i];
            //    for (int j = 0; j <i; j++) {
            //        if (lb < height[j]) { 
            //           lb = height[j];
            //        }
            //    }
            //    rb= height[i];
            //    for (int k = i + 1; k < height.Length; k++)
            //    {
            //        if (rb < height[k])
            //        {
            //            rb = height[k]; 
            //        }
            //    }
            //    wt = Math.Min(lb, rb);
            //    tw = wt - height[i];
            //    res += tw;
            //}
            //Console.WriteLine(res);
        }
    }
}

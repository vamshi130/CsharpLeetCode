using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class MaxSubArraySum
    {
        public static void MaxSubArray()
        {
            int[] arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int i = 0;
            int sum = 0;
            int len=arr.Length;
            int max = 0;
            while (i < len)
            {
                sum += arr[i];
                if (arr[i] > sum)
                {
                    sum = arr[i];
                }
                if (sum > max)
                {
                    max = sum;
                }
                i++;
            }



            // O(n2) complexity
            //int sum = 0;
            //int max = 0;
            //int[] arr = new int[] { 5, 4, -1, 7, 8 };
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i; j < arr.Length; j++)
            //    {
            //        sum += arr[j];
            //        max = Math.Max(sum, max);
            //    }
            //    sum = 0;
            //}
        }
    }
}

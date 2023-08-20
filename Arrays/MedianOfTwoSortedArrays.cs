using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class MedianOfTwoSortedArrays
    {
        private static int[] arr1 = new int[] { 1,3,8,17};
        private static int[] arr2 = new int[] { 5,6,7,19,21,25};
        private static int[] arr3 = new int[(arr1.Length + arr2.Length)];
        public static void Median()
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < arr1.Length || j<arr2.Length)
            {
                if (i < arr1.Length && arr1[i] < arr2[j])
                {
                    arr3[k]= arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    j++; k++;
                }
            }

            if (arr3.Length % 2 != 0)
            {
                Console.WriteLine(arr3[arr3.Length/2]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class MedianOfTwoArrays
    {
        public static void MedianOfTwoArray()
        {
            int[] arr1 = { 1, 2 };
            int[] arr2 = { 3, 4 };
            var len = arr1.Length + arr2.Length;
            int[] arr3 = new int[len];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i];
            }
            Array.Sort(arr3);


            if (arr3.Length % 2 != 0)
            {
                int med = (arr3.Length) / 2;
                Console.WriteLine(arr3[med] + "med");
            }
            else
            {
                int med = (arr3.Length) / 2;
                double median = (arr3[med] + arr3[med - 1]) / 2.000;
                Console.WriteLine(median + "med");
            }

            int j = 0;
            while (j < arr3.Length)
            {
                Console.WriteLine(arr3[j]);
                j++;
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    public static class ProductsOfElementsInAnArray
    {
        public static void ProductOfArray(int[] arr4)
        {
            //int[] arr1 = new int[arr.Length];
            //int[] res  = new int[arr.Length];
            //int temp = 1;
            //for(int i=0;i<arr.Length; i++)
            //{
            //    arr1[i] = temp;
            //    temp = temp * arr[i];
            //}
            //temp = 1;
            //for(int k =arr.Length-1; k>=0; k--)
            //{
            //    res[k] = arr1[k] * temp;
            //    temp *= arr[k];
            //}
            int[] arr = new int[] { 1, 4, 6, 9 };
            int[] arr1 = new int[] { 2, 3, 5, 8 };
            int i = 0; int j = 0;
            int k = 0;
            int[] arr3 = new int[arr.Length + arr1.Length];
            while (i < arr.Length && j < arr1.Length)
            {
                if (arr[i] < arr1[j])
                {
                    arr3[k] = arr[i];
                    i++;
                }
                else
                {
                    arr3[k] = arr1[j];
                    j++;
                }
                k++;
            }
            while(i< arr.Length)
            {
                arr3[k] = arr[i];
                i++;
            }
            while (j < arr1.Length)
            {
                arr3[k] = arr1[j];
                j++;
            }

            for (int l = 0; l < arr3.Length; l++)
            {
                Console.WriteLine(arr3[l]);
            }
        }
    }
}

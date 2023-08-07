using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    public static class ProductsOfElementsInAnArray
    {
        public static void ProductOfArray(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            int[] res  = new int[arr.Length];
            int temp = 1;
            for(int i=0;i<arr.Length; i++)
            {
                arr1[i] = temp;
                temp = temp * arr[i];
            }
            temp = 1;
            for(int k =arr.Length-1; k>=0; k--)
            {
                res[k] = arr1[k] * temp;
                temp *= arr[k];
            }
        }
    }
}

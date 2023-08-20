using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class RotateArray
    {
        private static int[] arr = new int[] { 1, 2, 3, 4, 5};
        private static int n = 7;
        public static void Rotate()
        {
            int j = 0;
            if (arr.Length < n)
            {
                n -=arr.Length;
            }
            while (j < n)
            {
                int temp = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i-1] = arr[i];
                }
                arr[arr.Length - 1] = temp;
                j++;
            }
            for(int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
        }
    }
}

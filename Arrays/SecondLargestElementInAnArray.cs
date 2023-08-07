using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class SecondLargestElementInAnArray
    {
        public static void SecondLargestElement(int[] arr)
        {
            //int[] arr = new int[] { 20, 42, 88, 10, 99, 6 };
            int max1 = 0;
            int max2 = 0;
            int j = 2;
            if (arr[0] > arr[1])
            {
                max1 = arr[0];
                max2 = arr[1];
            }
            else
            {
                max2 = arr[0];      
                max1 = arr[1];
            }
            for(int i= 2 ; i < arr.Length; i++)
            {
                if(arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2) { 
                max2 = arr[i];
                }
            }
            
            Console.WriteLine(max1 + "    "+ max2);
        }
    }
}

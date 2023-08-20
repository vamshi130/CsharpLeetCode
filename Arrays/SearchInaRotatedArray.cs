using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class SearchInaRotatedArray
    {
        public static int[] arr = new int[] {4,5,6,7,8,1,2 };
        public static int target = 8;
        public static void SearchElement()
        {
            var start = 0;
            var end = arr.Length - 1;
            var mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;    
                if (arr[mid] == target ) {
                    Console.WriteLine(arr[mid] +"     "+ mid);
                    break;
                }
                else if (arr[start] < arr[mid])
                {
                    if (target < arr[mid] && target >= arr[start] )
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if (target > arr[mid] && target <= arr[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
        }
    }
}

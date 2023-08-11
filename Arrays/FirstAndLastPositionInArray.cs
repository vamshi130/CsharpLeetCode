using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class FirstAndLastPositionInArray
    {
        public static void Position(int[] arr,int target)
        {
            int start = 0;
            int end= arr.Length-1;
            int mid = 0;
            int[] res = new int[2];
            while(start <= end)
            {
                mid = (start+end)/2;
                if (arr[mid] == target)
                {
                    res[0] = mid;
                    end = mid-1;
                }
                else if (target < arr[mid])
                {
                    end = mid-1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            start = 0;
            end = arr.Length-1;
            mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (arr[mid] == target)
                {
                    res[1] = mid;
                    start = mid + 1;
                }
                else if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            Console.WriteLine(res[1]+ " "+"hi");

        }
    }
}

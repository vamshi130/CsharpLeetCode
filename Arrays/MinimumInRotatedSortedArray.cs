using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class MinimumInRotatedSortedArray
    {
        public static void MinElement()
        {
            int[] arr = new int[] { 1,2 ,3};
            int start = 0;
            int end = arr.Length-1;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (start == end ) {
                    Console.WriteLine(arr[mid]);
                    return;
                }
                if (arr[mid] < arr[mid + 1] && arr[mid] < arr[mid - 1])
                {
                    Console.WriteLine(arr[mid]);
                    return;
                }
                else if (arr[mid] > arr[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
        }
        public static int ArrayChallenge(int[] n)
        {
            if (n.Length == 1)
            {
                return -1;
            }
            if (n[1] > n[0])
            {
                for (int i = 1; i < n.Length; i++)
                {
                    if (n[i] > n[i - 1])
                    {
                        continue;
                    }
                    if (i == n.Length - 1)
                    {
                        return -1;
                    }
                    return i;
                }
            }
            else
            {
                for (int i = 1; i < n.Length; i++)
                {
                    if (n[i] < n[i - 1])
                    {
                        continue;
                    }
                    if (i == n.Length - 1)
                    {
                        return -1;
                    }
                    return i;
                }
            }
            // code goes here  
            return -1; ;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class CountOfSmallOrEqualElements
    {
        //int[] arr = new int[] { 20, 32, 45, 66, 99, 100 };

        public static void count(int[] nums, int key) {
            int start = 0;
            int end = nums.Length-1;
            int mid;
            int k = -1;
            while (start < end)
            {
                mid = (start + end) / 2;
                if (nums[mid] == key)
                {
                    k= mid;
                    break;
                }
                else if (nums[mid] < key) {
                    start = mid+1;
                }
                else
                {
                    end = mid+1;
                }
            }
            Console.WriteLine(k + "  "+ "hi");
        }
    }
}

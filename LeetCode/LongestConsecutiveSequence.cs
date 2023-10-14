using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal static class LongestConsecutiveSequence
    {
        public static int ConsecutiveNumbers()
        {
            var stack=new Stack<int>();
            int[] nums = new int[] { -1,0,0,1 };
            Array.Sort(nums);
            //00123456789
            int count = 1;
            int j = 1;
            int min = 0;
            nums = nums.ToHashSet<int>().ToArray();
            for (int i = 0; i < nums.Length && j<nums.Length; i++)
            {
                //if (nums[j] - nums[i] == 0)
                //{
                //    count = 1;
                //    j++;
                //    continue;
                //}
                if (nums[j] == 0 && nums[i] == 0)
                {
                    j++;
                    count = 1;
                    continue;
                }
                if (nums[j] - nums[i] > 1)
                {
                    count = 1;
                    j++;
                    continue;
                }
                if (nums[j] - nums[i]==1) {
                    count++;
                    min = Math.Max(min, count);
                    j++;
                    continue;
                }
                j++;
            }
            return 0;
            //int[] nums = new int[] { 0, 3, 7, 2, 5, 4, 6, 0, 1,11,12,12,13,14,15,16,17,18,19,20,21 };
            //Array.Sort(nums);
            //int count = 1;
            //int min = 0;
            //if (nums.Length < 1)
            //{
            //    return 0;
            //}
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j <= i + 1; j++)
            //    {
            //        if (nums[j] - nums[i] == 0)
            //        {
            //            continue;
            //        }
            //        if (nums[j] - nums[i] == 1)
            //        {
            //            count += 1;
            //            if (min < count)
            //            {
            //                min = count;
            //            }
            //            continue;
            //        }
            //        if (nums[j] - nums[i] > 1)
            //        {
            //            count = 1;
            //        }
            //    }

            //}
            //Console.WriteLine(min);
            //return min;
        }
    }
}

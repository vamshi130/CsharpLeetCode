using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public static class BubbleSort
    {
        public static int closestNumber()
        {
            int[] nums = {0,0,0};
            int target = 5;
            var closest = int.MaxValue;
            int diff;
            int sum;
            int main = 0;
            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    for(int k=j+1; k<nums.Length; k++)
                    {
                        Console.WriteLine(nums[i] +" "+ nums[j]+" "+nums[k]);
                        sum = nums[i] + nums[j] + nums[k];
                        diff=Math.Abs(sum-target);
                        if(diff < closest)
                        {
                            closest = diff;
                            main = sum;
                        }
                    }
                }
            }
            return main;
                
            //int[] nums = { -1, 2, 1, -4 };
            //int target = 1;
            //Array.Sort(nums);
            //int mid = nums.Length / 2;
            //int first = nums[0];
            //int last=nums.Length - 1;
            //while(first <= last)
            //{
            //    if (nums[mid] > target)
            //    {
            //        first = mid;

            //    }
            //    else if (nums[mid] < target)
            //    {
            //        last = mid-1;
            //    }
            //    else
            //    {
            //        return nums[mid];
            //    }

            //}

            return 0;
        }
        public static int num(int first,int last,int target)
        {

            return 0;
        }
        
    }
}

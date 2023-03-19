using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class addingThreenumbersTogetZero
    {
        public static IList<IList<int>> addThreeNum()
        {
            int[] nums = new int[] {-1, 0, 0, 2, -1, 1};
            Array.Sort(nums);
            var results=new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 ||  (i>0 &&( nums[i] != nums[i - 1])))
                {
                    int start = i + 1;
                    int end = nums.Length - 1;
                    int sum = 0 - nums[i];
                    while (start < end)
                    {
                        if (nums[start] + nums[end] == sum)
                        {
                            var list = new List<int>() { nums[start], nums[end], nums[i] };
                            results.Add(list);
                            while (start < end && nums[start] == nums[start + 1]) start++;
                            while (start < end && nums[end] == nums[end - 1]) end--;
                            start++;
                            end--;
                        }
                        else if (nums[start] + nums[end] < sum)
                        {
                            start++;
                        }
                        else
                        {
                            end--;
                        }
                        
                    }
                }
            }
            Console.WriteLine(results.ToArray());
            return results ;
        }
    }
}


//var result = new List<IList<int>>();
//Array.Sort(nums);

//for (int i = 0; i < nums.Length; i++)
//{
//    if (i > 0 && nums[i] == nums[i - 1])
//    {
//        continue;
//    }
//    for (int j = i + 1; j < nums.Length; j++)
//    {
//        //if (i == j)
//        //{
//        //    continue;
//        //}
//        if (j != i + 1 && nums[j] == nums[j - 1])
//        {
//            j++;
//            continue;
//        }
//        for (int k = j + 1; k < nums.Length; k++)
//        {
//            //if (i == j || j == k || i == k || )
//            //{
//            //    continue;
//            //}
//            //if(k!=k+1 && nums[k] == nums[k - 1])
//            //{
//            //    k++;
//            //    continue;
//            //}
//            var num = nums[i] + nums[j] + nums[k];
//            var db = new List<int>() { nums[i], nums[j], nums[k] };
//            db.Sort();
//            if (num == 0)
//            {
//                result.Add(db);
//            }
//        }
//    }
//}
////for(int i=0;i< result.Count; i++)
////{
////   for(int j=i+1;j< result.Count; j++)
////    {
////        if(result[i].ToArray().SequenceEqual(result[j].ToArray()))
////        {
////            result.Remove(result[j]);
////            j--;
////        }
////    }
////}
//return result;
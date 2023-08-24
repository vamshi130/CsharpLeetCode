using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            HashSet<int> hash = new HashSet<int>(nums);
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach(var num in hash)
            {
                dict.Add(num, 0);
                Console.WriteLine(num);
                for (int j = 0; j < nums.Length; j++)
                {
                    if (num == nums[j])
                    {
                        dict[num] += 1;
                    }
                }
            }
            var d=dict.OrderByDescending(item => item.Value).Select(item => item.Key).Take(k).ToArray();

            return null;
            //int[] arr = new int[] { 10, 10, 20, 20, 40, 40, 40 };
            //Dictionary<int, int> dict = new Dictionary<int, int>();
            //dict.Add(0, 0);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!dict.ContainsKey(arr[i]))
            //    {
            //        dict.Add(arr[i], 0);
            //    }
            //}
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    if (dict.ContainsKey(arr[j]))
            //    {
            //        dict[arr[j]] += 1;
            //    }
            //}
            //var d = dict.OrderByDescending(item => item.Value).Select(item => item.Key).Take(2).ToArray();
            //Console.Write(d[0]);
        }
    }
}

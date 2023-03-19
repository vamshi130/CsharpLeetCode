using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class containerWithMostWater
    {
        public static void mostWater()
        {
            int[] height = new int[] { 2, 3, 4, 5, 18, 17, 6 };
            int maxWeight = 0;
            int minWeight = 0;
            int start = 0;
            //
            int end = height.Length-1;
            Console.WriteLine(end);
            while(start < end)
            {
                minWeight = Math.Min(height[start], height[end]) * (end-start);
                if(minWeight> maxWeight)
                {
                    maxWeight = minWeight;
                }
                if (height[start] < height[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            Console.WriteLine(maxWeight);
           
        }
    }
}
//int dist = 0;
//int minWater = 0;
//int maxWater = 0;
//int minNumber = 0;
//for (int i = 0; i < h.Length - 1; i++)
//{
//    for (int j = i + 1; j < h.Length; j++)
//    {
//        dist = j - i;
//        if (h[j] != h[i] || dist != 0)
//        {
//            maxWater = (dist * (Math.Min(h[i], h[j]))) > maxWater ? (dist * (Math.Min(h[i], h[j]))) : maxWater;
//            //minNumber = Math.Min(h[i], h[j]);
//            //minWater = dist * minNumber;
//            //if (minWater > maxWater)
//            //{
//            //    maxWater = minWater;
//            //}
//        }
//        else
//        {
//            minWater = h[i];
//            if (minWater > maxWater)
//            {
//                maxWater = minWater;
//            }
//        }
//    }
//}
//Console.WriteLine(maxWater);
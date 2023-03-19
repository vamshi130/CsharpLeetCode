using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class SlidingWindow
    {
        public static void slide()
        {
            int[] arr = new int[] { 2, 4, 6, 9, 3, 7, 11, 34, 5 };
            int k = 3;
            int window = 0;
            int maxSize = 0;
            for(int i = 0;i < k; i++)
            {
                window += arr[i];
                maxSize = window;
            }
            for(int j = k; j < arr.Length; j++)
            {
                window += arr[j] - arr[j-k];
                maxSize = Math.Max(maxSize, window);
            }
            Console.WriteLine(maxSize);
        }
    }
}

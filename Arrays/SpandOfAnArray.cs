using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class SpandOfAnArray
    {
        public static void Span(int[] arr)
        {
            int max = 0;
            int min = 0;
            for(int i=0;i<arr.Length; i++) {
                if (arr[i] > max)
                { 
                    max = arr[i];

                }
                if (arr[i] < max)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(max-min);
        }
    }
}

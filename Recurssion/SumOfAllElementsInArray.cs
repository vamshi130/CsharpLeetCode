using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    public static class SumOfAllElementsInArray
    {
        public static void SumOfArray(int[] arr, int sum, int i)
        {
            if (i > arr.Length-1)
            {
                Console.WriteLine(sum);
                return;
            }
            sum += arr[i];
            SumOfArray(arr, sum, i + 1);

        }
    }
}

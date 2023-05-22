using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    public static class TwoSum
    {
        public static void TwoSumZero()
        {
            int[] numbers = { 2, 7, 11, 15 };
            int[] array = new int[2];
            int target = 9;
            int start = 0;
            int end= numbers.Length-1;
            Array.Sort(numbers);
            while (start < end) { 
                if (numbers[start] + numbers[end] > target)
                {
                    end--;
                }
                else if(numbers[start] + numbers[end] < target)
                {
                    start++;
                }
                else
                {
                    array[0] = start+1;
                    array[1]=end+1;
                    break;
                }
            }
            Console.WriteLine(array);
        }
    }
}

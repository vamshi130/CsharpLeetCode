using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class BooksAllocation
    {
        private static int[] arr = new int[] { 12,34,67,90 };
        private static int num = 2;
        public static void BooksAllocate() 
        {
            int sum = arr.Sum();
            Console.WriteLine(sum);
            int res = 0;
            int start = arr[0];
            int end = sum;
            int mid = 0;
            while (start <= end) { 
                mid= (start + end) / 2;
                if (IsPossible(mid,arr))
                {
                    res = mid;
                    end = mid-1;
                }
                else
                {
                    start = mid+1;
                }
            }
            Console.WriteLine(res);
        }
        public static bool IsPossible(int mid, int[] arr) {
            int sc = 0;
            int students = 0;
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i]+ sc < mid)
                {
                    sc += arr[i];
                }
                else
                {
                    students++;
                    if(students >= num)
                    {
                        return false;
                    }
                    sc = arr[i];
                }
            }
            return true;
          
        }
    }
}

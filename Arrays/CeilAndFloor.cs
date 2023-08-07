using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class CeilAndFloor
    {
        public static int Ceil(int[] arr, int num)
        {
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine(arr[i]);  
                    return arr[i];
                }
                else if (arr[i] > num)
                {
                    Console.WriteLine(arr[i]);
                    return arr[i];
                }
            }
            Console.WriteLine("-1");
            return -1;
        }
    }
}

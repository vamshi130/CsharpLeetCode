using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class MoveZeroesEnd
    {
        private static int[] arr = new int[] { 2, 1, 0, 0, 3, 0, 4, 0 };
        public static  void MoveZeroes()
        {
            int nz = 0;
            int n = 0;
            for(int i=0;i<arr.Length;i++)
            {
                
                    if (nz < arr.Length && arr[nz] == 0 )
                    {
                        nz++;
                    }

                    if (n<arr.Length && arr[n] != 0)
                    {
                        n++;
                    }

                    if (nz < arr.Length &&n<arr.Length && arr[nz] != 0 && arr[n] == 0)
                    {
                        int temp = arr[nz];
                        arr[nz] = arr[n];
                        arr[n] = temp;
                        nz++;
                        n++;
                    }
            }

        }
    }
}

using System;
using System.Linq;

namespace LINQ
{
   class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[] {9,8,7,6,5,4,3,2,1,44,5,7,4,3,6,4,3,5,6,76,65,4,33,4,3,5,6,4,3,32};
            var array1=from i in array where i>30 orderby i descending select i;
            foreach(var i in array1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello World!");
        }
    }
}

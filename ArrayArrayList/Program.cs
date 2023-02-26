using System;
using System.Collections;

namespace ArrayArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array=new string[2];
            array[0] = "vamshi";
            array[1] = "Krishna";
            foreach (string s in array)
            { Console.WriteLine(s); }   

            //ArrayList are non geniric which can store any type of data
            //
            var arraylist=new ArrayList();
            //arraylist.Add(array);
            arraylist.Add(100);
            arraylist.AddRange(new ArrayList() { "ravi","pavan"});
            //arraylist.Remove(3);

                foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace HastSet
{
    //hashset stores only the unique values
    internal class Program
    {
        static void Main(string[] args)
        {
            var hashValues = new HashSet<string>()
                  {  "Vamshi", "Krishna" };
            foreach(var value in hashValues)
            {
                Console.WriteLine(value);
            }
            hashValues.Add("Vinay");
            bool b = hashValues.Contains("Vinay");
            hashValues.RemoveWhere(m => m.StartsWith("K")); 
            Console.WriteLine("Hello World!");
        }
    }
}

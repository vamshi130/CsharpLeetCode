using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lists = new List<string>();
            lists.Add("Csharp");
            lists.Add("Java");
            var lists2 = new List<string>()
            {
                "Cpp",
                "Ruby",
                "Python",
                "Cpp",
                
            };
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
            foreach (var item in lists2)
            {
                Console.WriteLine(item);
            }
        }
    }
}

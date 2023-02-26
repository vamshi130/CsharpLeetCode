using System;

namespace ExtensionMethods
{
     class Program
    {
        public void Test1()
        {
            Console.WriteLine("Test 1 of program class");
        }
        public void Test2()
        {
            Console.WriteLine("Test 2 of the program class");
        }
        
        static void Main(string[] args)
        {
            var p= new Program();
            p.Test1();
            p.Test2();  

            
        }
    }
}

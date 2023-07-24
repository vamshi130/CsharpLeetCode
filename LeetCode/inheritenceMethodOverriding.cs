using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    public class InheritenceMethodOverriding
    {
        public void baseClass()
        {
            Console.WriteLine("Base Class A");
        }
        public virtual void Test()
        {
            Console.WriteLine("Test Class A");
        }
    }
    public class ChildClass : InheritenceMethodOverriding { 
        public void childClass()
        {
            Console.WriteLine("Child Class B");
        }
        public override void Test()
        {
            Console.WriteLine("Test Class B");
        }
    }
    public static class RecursionTest
    {
        public static void Recusrion(int n)
        {
            if (n > 1)
            {
                return;
            }
            for(int i = n; i > n; i--)
            {
                Console.WriteLine("hi" + " " + i);
                Recusrion(n-1);
                Console.WriteLine("Back Tracking" + " " + i);

            }
        }
    }
}

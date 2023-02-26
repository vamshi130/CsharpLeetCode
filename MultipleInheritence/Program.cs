using System;

namespace Interfaces
{
    interface IMultipleInheritence
    {
        void show();
        void print();
    }
    interface IMultipleInheritence1
    {
        void show();
        void print();
    }
    public class MultipleInheritence : IMultipleInheritence, IMultipleInheritence1
    {
        void IMultipleInheritence.print()
        {
            Console.WriteLine("first Inheritence method");
        }
        void IMultipleInheritence1.print()
        {
            Console.WriteLine("second Inheristence method");
        }
        public void show()
        {
            Console.WriteLine("welcome mutiple inheritence");
        }

        static void Main()
        {
            MultipleInheritence a = new MultipleInheritence();
            IMultipleInheritence obj = a;
            IMultipleInheritence1 obj1 = a;
            obj1.print();
            obj.print();
            a.show();

        }

    }
}


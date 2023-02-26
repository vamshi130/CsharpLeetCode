using System;

namespace AbstractClass
{
   public abstract class Program
    {
        public void show()
        {
            Console.WriteLine("i am a non abstract method");
        }
        public abstract void print();
        
    }
    public class abstractClass : Program
    {
        public override void print()
        {
            Console.WriteLine("abstract print method is executing");
        }
        static void Main()
        {
            abstractClass obj = new abstractClass();
            obj.show();
            obj.print();
            Console.WriteLine("Hello World!");
        }


    }

}

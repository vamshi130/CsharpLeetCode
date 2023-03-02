using System;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=delegates.addNumbers(10, 20);
            delegates str=new delegates();
            string name = str.returnName("vamshi");
            addDelegate del = new addDelegate(delegates.addNumbers);
            returnDelgate delName = new returnDelgate(str.returnName);
            int delres = del(100, 200);
            string resName = delName("krishna");
            Console.WriteLine(num);
            Console.WriteLine(name);
            Console.WriteLine(delres);
            Console.WriteLine(resName);


        }
    }
}

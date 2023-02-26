using System;

namespace Generics
{

    //class generics
    //{
    //    public bool Checkfun(int a,int b)
    //    {
    //        if (a==b)
    //        {
    //            return true;
    //        }
    //        return false;

    //    }
    //}
    //class generics
    //{
    //    public bool Checkfun(object a,object b)
    //    {
    //        if (a.Equals(b))
    //        {
    //            return true;
    //        }
    //        return false;

    //    }
    //}
    class generics
    {
        public bool Checkfun<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;

        }
        public void Addition<T>(T c ,T d)
        {
            dynamic d1=c;
            dynamic d2=d;
            Console.WriteLine(d1+ d2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj=new generics();
            //Console.WriteLine(obj.Checkfun(2,3);
            Console.WriteLine( obj.Checkfun<int>(2,3));
            obj.Addition<int>(2,3);
            Console.WriteLine("Hello World!");
        }
    }
}

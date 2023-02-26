using System;

namespace ValueTypeClassTypeReferenceType
{
    internal class Program  //here class is a userdefined type
    {
        int x = 100; //here int is a datatype and x is a copy of int i.e  a variable
        static void Main(string[] args)
        {
            //Console.WriteLine(x); Here static member cannot access the non static member
            Program pg =new Program();  //here pg is the instance of class
            Program pg1;                //here pg1 is the varibale of class
            pg1 = new Program();        //here pg1 is the instance of a class
            Program PgReference;
            PgReference=pg1;            //here PgReference is the Reference of a class
                                        // for referenece memory should not allocated but use like a instance.
            Console.WriteLine(pg1.x);
            Console.WriteLine(pg.x);
            Console.WriteLine(PgReference.x);
            

        }
    }
}

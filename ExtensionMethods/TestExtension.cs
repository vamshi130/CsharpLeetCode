using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public  class TestExtension
    {
        public static void Main()
        {
            Program pg=new Program();
            pg.Test2();
            pg.Test1();
            pg.Test3();
            int fvalue = 6;
            int i = 5;
            i.Factorial();
            var factorialResult = fvalue.Factorial();
            Console.WriteLine(factorialResult);

            String str = "KunUguntla VAmShi kRisHna";
            var obj=str.ToProper();
            Console.WriteLine(obj);
            
        }


    }
}

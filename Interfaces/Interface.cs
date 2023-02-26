using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Interface
    {
        void Add(int a , int b);
    }
    interface Interface2 : Interface
    {
        void Sub(int a , int b);    
    }
    class Calculation : Interface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("a + b: "+ a + b);
        }

        public  void Sub(int a, int b)
        {
            Console.WriteLine( a - b);
        }

        static void Main()
        {
            Calculation calculation = new Calculation();
            Interface2 obj = calculation;
            obj.Add(1, 2);
            obj.Sub(3, 2);
            calculation.Add(1, 2);
            calculation.Sub(1, 2);
        }
    }


}

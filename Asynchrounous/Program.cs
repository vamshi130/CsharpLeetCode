using System;
using System.Threading.Tasks;

namespace Asynchrounous
{
    class Program
    {
        static async Task Main(string[] args)
        {
           await Test();
            
        }
        static Task Test()
        {
            var t1 = Task.Run(() => Console.WriteLine("Task 1 "));
            var t2 = Task.Run(() => Console.WriteLine("Task 2"));
            var t3 = Task.Run(() => Console.WriteLine("Task 3 "));
            Console.WriteLine("Hello World!");
            Task.WaitAll(t1, t2, t3);
            return Task.CompletedTask;
        }
    }

}

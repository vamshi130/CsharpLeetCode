using System;

namespace Chsarp_EnumDictionariesHashSEtCollections
{
    public enum States
    {
        Telanagna,AndhraPradesh,Kerala,Banglore,Tamilnadu,Punjab
    }
    internal class Enums
    {
        public static States StateTour { get; set; } 

        static void Main(string[] args)
        {
            States days = States.Telanagna;
            States days1 = (States)3;
            Console.WriteLine(days);
            Console.WriteLine(days1);
            foreach(string i in Enum.GetNames(typeof(States)))
            {
                Console.WriteLine(i);
            }
            foreach (int i in Enum.GetValues(typeof(States)))
            {
                Console.WriteLine(i);
            }

          
            Console.WriteLine("-------------````````````````------------------");
            Console.WriteLine(StateTour);
            StateTour = States.Banglore;
            Console.WriteLine((StateTour));    
            Console.BackgroundColor=  ConsoleColor.Green;

            Console.WriteLine("Hello World");
           
            
            
        }
    }
}

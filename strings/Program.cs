using System;
using System.Text;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String clone
            String s1 = "hello";
             s1 = s1 + "krishna";
            String s2 = (string)s1.Clone();
            Console.WriteLine(s2);
            //String Compare
            String s3 = "Compare";
            Console.WriteLine(String.Compare(s2, s3));
            //String CompareTo
            Console.WriteLine(s3.CompareTo(s1));
            //String Concat
            Console.WriteLine(String.Concat(s2, s3));   
            //String Contains
            Console.WriteLine(s3.Contains(s1));
            //string copy
            //string s4 = string.Copy(s1);
            //Console.WriteLine(s4);
            //String format
            Console.WriteLine("string format------------");
            string s5 = string.Format("4", "krishna");
            Console.WriteLine(s5);
            String s6 = "Immutable";
            s6 = s6 + "creating immutable string";
            StringBuilder str = new StringBuilder();
            str.Append("it is a Mutable");
            


        }
    }
}

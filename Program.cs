using System;

namespace StringMaker_Martin
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManager sm = new StringManager();
            Console.WriteLine(sm.ToString());
            Console.WriteLine(sm.Reverse("Sunbeam Tiger"));
            Console.WriteLine(sm.Equals("Sunbeam Tiger"));
            Console.WriteLine(sm.Symmetric("ABBA"));
            Console.WriteLine(sm.Symmetric("ABA"));
            Console.WriteLine(sm.Symmetric("ABba"));
            Console.ReadLine();

        }
    }
}

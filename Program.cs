using System;

// Jordan Martin
// IT113
// I used a lot of prebuilt methods to reduce creating temporary objects.
// In the methods I would take the input value and call ToCharArray or ToString ect.

// I didn't do a queue I decided to go with a stack instead. A stack is less coding and can you can seperate a string to a char aray and easily push it to the stack and pop it out to be a reversed string.
// While with a queue its first in first out. You would need to add it on the cue but then grab the first object in the queue and sort it to the back of an array.

namespace StringMaker_Martin
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManager sm = new StringManager("dddddddddddd5");
            Console.WriteLine(sm.ToString());
            Console.WriteLine(sm.Reverse("Sunbeam Tiger"));
            Console.WriteLine(sm.Reverse("Sunbeam Tiger", true));
            Console.WriteLine(sm.Equals("Sunbeam Tiger"));
            Console.WriteLine(sm.Symmetric("ABBA"));
            Console.WriteLine(sm.Symmetric("ABA"));
            Console.WriteLine(sm.Symmetric("ABba"));
            Console.ReadLine();

        }
    }
}

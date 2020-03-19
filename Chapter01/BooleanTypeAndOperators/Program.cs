using System;

namespace BooleanTypeAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference type, based on reference
            //Boolean value requires only one bit of storage, the runtime will use one byte of memory 
            int x = 1;
            int y = 2;
            int z = 1;
            Console.WriteLine(x == y); //False
            Console.WriteLine(x == z); //True

            //other example: (Class Dude)
            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2); //False
            Dude d3 = d1;
            Console.WriteLine(d3 == d1); //True
            Console.WriteLine(d1 == d3); //True

        }
    }
}

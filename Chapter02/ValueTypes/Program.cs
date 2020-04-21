using System;

namespace ValueTypes
{
    /*Pag.25- Value types comprise most built-in types (specifically, all numeric types, the char type, and the bool type)
    as well as custom struct and enum types.
    FUNDAMENTAL DIFFERENCE: How they are handled in memory */

    class Program
    {
        static void Main(string[] args)
        {
            //int i; } //the content of the built-in value type, int, is 32 bits of data.

            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1; //Assigment causes copy
            Console.WriteLine(p1.X); //7
            Console.WriteLine(p2.X); //7

            p1.X = 9; //Change p1.X
            p2.X = 5;
            //p1 and p2 have independent storage.

            Console.WriteLine(p1.X); //9
            Console.WriteLine(p2.X); //7
        }

        
        //public struct Point { public int X; public int Y; }
        //public struct Points { public int X, Y; }





    }
}


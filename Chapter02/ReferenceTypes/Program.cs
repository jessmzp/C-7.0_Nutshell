using System;

namespace ReferenceTypes
{
    //Is more complex than a value type: having two parts: an object and the reference to that object
    //The content: is a reference to an object that contains the value.
    class Program
    {
        static void Main(string[] args)
        {
            //Assigning a references-type variable copies the reference, not the object instance.
            //This allows multiple variables to refer to the same object.
            //AN OPERATION TO P1 AFFECTS P2.

            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1; //Copies p1 reference
            Point p3 = p1;
            Console.WriteLine(p1.X);//7
            Console.WriteLine(p2.X);//7
            Console.WriteLine(p3.X);//7

            p1.X = 9;  //Change p1.X

            Console.WriteLine(p1.X); //9
            Console.WriteLine(p2.X); //9
            Console.WriteLine(p3.X);//9

            p1.Y = 5;
            p2 = p1;
            Console.WriteLine(p1.Y);//5
            Console.WriteLine(p2.Y);//5
         
            p1.Y = 10;
            Console.WriteLine(p1.Y);//10
            Console.WriteLine(p2.Y);//10

            p2.Y = 4;
            Console.WriteLine(p1.Y);//4
            Console.WriteLine(p2.Y);//4


        }
    }
}

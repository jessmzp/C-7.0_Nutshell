using System;

namespace SpecialFloatAndDoubleValues
{
    class Program
    {
        //NaN-------------Not a number
        static void Main(string[] args)
        {
            Console.WriteLine(double.NegativeInfinity); //-Infinity
            Console.WriteLine(double.PositiveInfinity);
            Console.Write(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity);

            Console.WriteLine(1.0 / 0.0);   //Infinity
            Console.WriteLine(-1.0 / 0.0);  //-Infinity
            Console.WriteLine(1.0 / -0.0);  //-Infinity
            Console.WriteLine(-1.0 / -0.0); //Infinity

            Console.WriteLine(0.0 / 0.0); //NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); //NaN

            //When using ==, a NaN value is never equal to another value,even another NaN value:
            Console.WriteLine(0.0 / 0.0 == double.NaN); //False

            //To test whether a value is NaN, you must use the float.IsNaN or double.IsNaN
            Console.WriteLine(double.IsNaN(0.0 / 0.0)); //True

            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN)); //True




        }
    }
}

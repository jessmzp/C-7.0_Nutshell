using System;

namespace Conversions
{
    class Program
    {
        //Pag 24. CONVERSIONS
        static void Main(string[] args)
        {
            //Implicits conversions: happen automatically.
            //Explicits conversions: require a cast.

            //Implicitly convert an int to a long type 
            int x = 12345; //int is a 32-bit integer
            long y = x; //Implicit conversion to 64-bit integral type
            Console.WriteLine(x);
            int i=1;
            float f=i;


            //Explicitly cast an int to a short type 
            short z = (short)x; //Explicit conversion to 16-bit integral type
            Console.WriteLine(x);
            //long z = (long)x;
            int i2=(int)f;


            int i1= 100000001;
            float f=i1; //Magnitude preserved, precision lost
            int i2=(int)f; //100000000
        }
    }
}

using System;

namespace VariablesAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);
            //The StringBuilder referenced by ref1 is now eligible for GC.

            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;
            //The StringBuilder referenced by ref2 is NOT yet eligible for GC.
            Console.WriteLine(ref3);

            //A variable represents a storage location that has a modifiable value.
            //STACK- Is a block of memory for storing local variables an parameters.
             static int Factorial(int x)
             {
     
                 if (x == 0)
                 {
                     return 1;
                 }
                 else
                 {
                     return x * Factorial(x - 1);
                 }

             }
            //HEAP- Is a block of memory in which objects reside.
        }
    }
}

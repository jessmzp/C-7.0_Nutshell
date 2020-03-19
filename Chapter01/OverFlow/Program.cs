using System;

namespace OverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int a = 1000000;
             int b = 1000000;
             int c = checked(a * b); //check just the expression.

             checked //Checks all expressions in statement block.
             {
                 c = a * b;
             }

             int a = int.MinValue;
             a--;
             Console.WriteLine(a == int.MaxValue);

            int x = int.MaxValue;
            int y = unchecked(x + 1);
            unchecked { int z = x + 1; } */

            //Overflow checking for constant expressions
            int x = int.MaxValue + 1; //Compile-time error
            int y = unchecked(int.MaxValue + 1); //No errors

        }
    }
}

using System;

namespace DefiniteAssignment
{
    class Program
    {
        //C# enforces a definite assignment policy. In practice, this means that outside of an unsafe context, its impossible to access uninitializes memory.
        //Definite assignment has three implications.

        //Local variables must be assigned a value before they can be read.
        //Function arguments must be supplied when a method is called.
        //All other variables (such as fields an array elements) are automatically initialized by the runtime.
        static void Main()
        {
            int[] ints = new int[2];
            Console.WriteLine(ints[0]);
            Console.WriteLine(ints[1]);
        }
        //Default Value
        //All references types============NULL
        //All numeric and  enum types=====0
        //char type======================='\0'
        //bool type=======================FALSE
    }
}

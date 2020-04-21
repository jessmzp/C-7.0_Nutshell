using System;

namespace Parameters
{
    class Program
    {
        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }
        static void Main(string[] args)
        {
            int x = 8;
            Foo(x);
            Console.WriteLine(x);
            //Foo(8);
        }
        //Assigning p a new value does not change the contents of x, since p anx x reside in different memory locations.

        //Passing a reference-type argument by value copies the reference, but not the object.

    }
}

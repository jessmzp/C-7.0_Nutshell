using System;

namespace IncrementDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Console.Write("The value of x here is {0} \n", x);
           
            Console.WriteLine(x++); //Outputs 0; x is now 1
            Console.Write("The value of x here is {0} \n", x);
            //Console.Write(++x);
            //Console.WriteLine(y++); 
            Console.Write("The value of y here is {0} \n", y);
            Console.Write(++y); //Outputs 1; y is now 1
            Console.Write("\n The value of y here is {0} \n", y);

        }
    }
}

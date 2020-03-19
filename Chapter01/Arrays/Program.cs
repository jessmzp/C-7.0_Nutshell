using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //represents a fixed number of variables(called elements) of a particular type.
            //The elements in an array are always stored in a contiguous block of memory, providing highly efficient access.

            char[] vowels = new char[5]; //Declare an array of 5 characters..

            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            Console.WriteLine(vowels);
            Console.WriteLine(vowels[0] + "\t"+ vowels[1] + "\n"+ vowels[2] + "\t" + vowels[3] + "\n"+ vowels[4]);

            foreach(char item in vowels)
            {
                Console.WriteLine(item.ToString());
            }

           


            
        }
    }
}

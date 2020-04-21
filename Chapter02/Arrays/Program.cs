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
            Console.WriteLine(vowels[0] + "\t" + vowels[1] + "\n" + vowels[2] + "\t" + vowels[3] + "\n" + vowels[4]);

            Console.WriteLine("Print in a foreach:\n ");
            foreach (char item in vowels)
            {
                Console.WriteLine(item.ToString());
            }
            //The length property returns the numer of elements in the array
            //Once an array has been created, its length cannot be changed
            Console.WriteLine("Print in a for:\n ");
            for (int i = 0; i < vowels.Length; i++)
                Console.WriteLine(vowels[i]);

            //Array initialization expression:
            char[] vowelsTwo = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] vowelsthree = { 'a', 'e', 'i', 'o', 'u' };

            //Default Element
            int[] a = new int[1000];
            Console.Write(a[123]); //0

            //MULTIDIMENSIONAL ARRAYS: Rectangular and Jagged
            //Rectangular arrays: Are declared using commas to separate each dimension.

            int[,] matriz = new int[3, 3];

            //GetLength returns the length for a given dimensions
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    matriz[i, j] = i * 3 + j;
            int[,] RectangularArray = new int[,]
            {
                {0,1,2 },
                {3,4,5 },
                {6,7,8 },
            };

            //Jagged arrays: are declared using successive square brackets to represent each dimensions.
            int[][] matrix = new int[3][];

            for (int i=0; i< matrix.Length; i++)
            {
                matrix[i] = new int[3]; //Create inner array
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = i * 3 + j;
            }

            //Jagged array can be initialized:
            int[][] jaggedArray = new int[][]
            {
                new int[]{0,1,2},
                new int[]{3,4,5},
                new int[]{6,7,8,9}
            };

            //SIMPLIFIED ARRAY INITIALIZATION EXPRESSIONS
            //There are two ways to shorten array initialization expressions.
            //===FIRST: To omit the new operator and type qualifications:

            char[] vowelsArray = { 'a', 'e', 'i', 'o', 'u'};
            var vowel=new[] { 'a', 'e', 'i', 'o', 'u' }; 
            int[,] rectangulatMatrix =
            {
                {0,1,2 },
                {3,4,5 },
                {6,7,8 },
            };
            int[][] jaggedMatrix =
            {
               new int[]{0,1,2},
               new int[]{3,4,5},
               new int[]{6,7,8,9}
            };
            //===SECOND: To use the var keyword, which tells the compiler to implicitly type a local variable:
            var i = 3; //i is implicitly of type int
            var s = "sausage"; // s is implicitly of type string
            //therefore

            var rectMatrix = new int[,]   //rectMatrix is implicitly of type int[,]
             {
                {0,1,2 },
                {3,4,5 },
                {6,7,8 },
             };

            var jaggedMat = new int[][] //jaggedMat is implicitly of type int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8},
            };


        }

    }
}

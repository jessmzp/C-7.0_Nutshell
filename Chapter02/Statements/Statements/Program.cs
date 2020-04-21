using System;
using System.Text;

namespace Statements
{
    // Pages: 62-
    //Functions comprise statements that execute sequentially in the textual order in which they appear.
    //A statement block is a series of statements appearing between braces (the {} tokens).
    class Program
    {
        static void Main(string[] args)
        {
            TellMeWhatICanDo(15);
            ShowCard(12);
          
            int x; //local variable
            {
              //  int y;
            }
            {
               // int y;
            }
           // Console.Write(y); // Error - y is out of scope.
            //Declaration Statements
            string someWord = "rosebud";
            int someNumber = 42;
            bool rich = true, famous = false;

            const double c = 2.99792458E08; //It cannot be changed after it has been declared. 
           // c += 10; //Compile-time Error.

            // DECLARE VARIABLES WITH DECLARATION STATEMENTS
            string s;
            int y, z;
            System.Text.StringBuilder sb;

            //EXPRESSION STATEMENTS
            x = 1 + 2; //Assignment expression
            x++; //Increment expression
            y = Math.Max(x, 5); //Assignment expression
            Console.WriteLine(y); //Method call expression
            sb = new StringBuilder();//Assignment expression
            new StringBuilder(); //Object instantiation expression

            //When you call a constructor or a method that returns a value, you're not obliged to use the result.

            //Legal, but useless:
            new StringBuilder(); 
            new string('c', 3);
            x.Equals(y);

            //SELECTION STATEMENTS
             //Selection Statements (if, switch)
             //Conditional operator (?:)
             //Loop statements (while, do..while, for, foreach)

            //THE IF STATEMENT

           if(5 < 2 * 3 )
            Console.WriteLine("true");

           //The statement can be a code block
           if(5< 2 * 3)
            {
                Console.WriteLine("true");
                Console.WriteLine("Let's move on!");
            }

            //THE ELSE CLAUSE
            //An if statement can optionally feature and else clause:

            if (2 + 2 == 5)
                Console.WriteLine("Does not compute");
            else
                Console.WriteLine("False");

            //Within an else clause, you can nest another if statement:
            if (2 + 2 == 5)
                Console.WriteLine("Does not compute");
            else
                if (2 + 2 == 4)
                Console.WriteLine("Computes");

            //CHANGING THE FLOW OF EXECUTION WITH BRACES
            if (true)
                if (false)
                    Console.WriteLine();
                else
                    Console.WriteLine("executes");

            //Semantically identical to:
            if(true)
            {
                if (false)
                    Console.WriteLine();
                else
                    Console.WriteLine("executes");
            }

            //Changing the execution flow by moving the braces:
            if (true)
            {
                if (false)
                    Console.WriteLine();
            }
            else
                Console.Write("does not execute");
            //

            static void TellMeWhatICanDo (int age)
            {
                if (age >= 35)
                    Console.WriteLine("You can be president");
                else if (age >= 21)
                    Console.WriteLine("You can drink");
                else if (age >= 18)
                    Console.WriteLine("You can vote");
                else if(age < 18)
                    Console.WriteLine("You can wait, You are a baby");
            }
            
            //SWITCH STATEMENT

            static void ShowCard(int cardNumber)
            {
                switch (cardNumber)
                {
                    case 13:
                    case 14:
                    case 15:
                        Console.WriteLine("King");
                        break;
                    case 12:
                        Console.WriteLine("Queen");
                        break;
                    case 11:
                        Console.WriteLine("Jack");
                        break;
                    case -1:  //Joker is -1
                        goto case 12; //In this game joker counts as queen
                    default:          //Executes for any other cardNumber
                        Console.WriteLine(cardNumber);
                        break;
                }
                TellMeTheType(12);
                TellMeTheType("hola");
                TellMeTheType(true);
                TellMeTheType(12f);

                //THE SWITCH STATEMENMT WITH PATTERNS
                static void TellMeTheType ( object x)
                {
                    switch (x)
                    {
                        case int i:
                            Console.WriteLine("Its an int");
                            Console.WriteLine($"Te square of {i} is {i * i} ");
                            break;
                        case string s:
                            Console.WriteLine("It's a string");
                            Console.WriteLine($"The length of {s} is {s.Length}");
                            break;
                        case bool b:
                            Console.WriteLine("It's a bool");
                            break;
                        default:
                            Console.WriteLine("I don't know what x is");
                            break;
                 
                    }

                    switch (x)
                    {
                        case bool boo when boo == true:
                            Console.WriteLine("True");
                            break;
                        case bool boo:
                            Console.WriteLine("False");
                            break;
                        case null:
                            Console.WriteLine("Nothing here");
                            break;
                    }

                    /* switch(x)
                     {
                         case float f when f > 1000;
                         case double d when d > 1000;
                         case decimal m when m > 1000;
                         Console.WriteLine("We can refer to x here but not f or d or m");
                         break;*/             
                }
            }
            //========================================================================================    
            //ITERATION STATEMENTS
            //WHILE AND DO-WHILE LOOPS
            //While loops repeatedly execute a body of code while a bool expression is true.
            //The expression is tested before the body of the loop is executed.
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine("The number is with while:" + j);
                j++;

            }
            //DO-WHILE LOOPS differ in functionality from while loops only in that they test the expression after
            //the statement block has executed
            int k = 0;
            do
            {
                Console.WriteLine("The number with do While:"+ k);
                k++;
            }
            while (k < 3);

            //FOR LOOPS
            //Are like while loops with special clauses
            //for(initialization-clause; condition-clause; iteration-clause) statement-or-statement-block
            //INITIALIZATION CLAUSE: Executed before the loop begins; used to initialize one or more iteration variables.
            //CONDITION CLAUSE: The bool expression that, while true, will execute the body.
            //ITERATION CLAUSE: Executed after each iteration of the statement block; used typically to update the iteration variable.

        }
    }

}


using System;

namespace StringsAndCharacters
{
    class Program
    {
        //Occupies 2 bytes.
        static void Main(string[] args)
        {
            char c = 'A'; //Simple character

            //=============SCAPE SEQUENCE CHARACTERS=============

            char newLine = '\n';
            char backSlash = '\\'; // \
            char singleQuote = '\''; // '
            char @null = '\0';
            char alert = '\a';
            char backSpace = '\b';
            char formFeed = '\f';
            char carriageReturn = '\r';
            char horizontalTab = '\t';
            char verticalTab = '\v';

            /*Console.WriteLine(newLine);
            Console.WriteLine(backSlash);
            Console.WriteLine(singleQuote);
            Console.WriteLine(@null);
            Console.WriteLine(alert);
            Console.WriteLine(backSpace);
            Console.WriteLine(formFeed);
            Console.WriteLine(carriageReturn);
            Console.WriteLine(horizontalTab);
            Console.WriteLine(verticalTab);*/

            //The \u (or \x) escape sequence lets you specify any Unicode character via its fourdigit hexadecimal code:

            char copyrightSymbol = '\u00A9';
            char omegaSymbol = '\u03A9';
            char newLineTwo = '\u0009';

            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(omegaSymbol);
            Console.WriteLine(newLineTwo);

            //String is a reference type 
            string a = "test";
            string b = "test";
            Console.Write(a == b);//True

            //The scape sequences that are valid for char literals also work inside strings
            string tab = "Here is a tab: \t ";
            Console.Write(tab);

            string tab2 = "\\\\server\\fileshare\\helloworld.cs";
            Console.Write(tab2);

            //verbatim string literals
            //==========VERBATIM STRING LITERALS========================
            string verbatimTest = @"\\server\fileshare\helloworld.css";
            //A verbatim string literal can also span multiple lines:
            string scaped = "First Line \r \n Secon Line";
            string verbatim = @"First Line Second Line";
            //True is your IDE uses CR-LF line separators
            Console.WriteLine(scaped);
            Console.WriteLine(verbatim);
            Console.WriteLine(scaped == verbatim);
            Console.WriteLine(verbatimTest);

            string xml = @"<customer id=:""123""></customer>";

            //=========STRING CONCATENATION============================

            string s = "a" + "b";
            Console.WriteLine(s);
            string s2 = "a" + 5;//a5
            Console.WriteLine(s2);

            //=========STRING INTERPOLATION============================
            //A string preceded with the $ character is called an interpolated string.

            int x = 4;
            Console.WriteLine($"A square has {x} sides"); //A square has 4 sides

            string s3 = $"255 in hex is {byte.MaxValue:X2}"; //X2= 2-digit Hexadecimal
            Console.WriteLine(s3);
            
            //Evaluates to "255 in hex is FF"

            int x1 = 2;
            string s4 = $@"this spans{x1} lines";
            Console.WriteLine(s4);

        }

    }
}

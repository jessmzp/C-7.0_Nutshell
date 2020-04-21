using System;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //The useUmbrella method returns true if it's rainy or sunny(to protect us from the rain or the sun)
            //as long as it's not also windy(since umbrellas are useless in the wind).

            static bool UseUmbrella( bool rainy, bool sunny, bool windy)
            {
                return !windy && (rainy || sunny);

                //The & and | operators also test for and and or conditions:
                return !windy & (rainy | sunny);
            }
            //The ternary operator
            //t’s theonly operator that takes three operands) has the form q ? a: b, where if condi‐tion q is true, a is evaluated, else b is evaluated.
            static int Max (int a, int b)
            {
                return (a > b) ? a : b;
            }
          
        }
    }
}

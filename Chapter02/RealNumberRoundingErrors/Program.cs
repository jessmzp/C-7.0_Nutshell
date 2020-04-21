using System;

namespace RealNumberRoundingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            float tenth = 0.1f; //Not quite 0.1
            float one = 1f;
            Console.WriteLine(one - tenth * 10f); //-1.490116E-08

            decimal m = 1M / 6M;  //0.16667M
            double d = 1.0 / 6.0; //0.16666

            decimal notQuiteWholeM = m + m + m + m + m + m; //1.00002M
            double notQuiteQholeD = d + d + d + d + d + d; //0.999989

        }
    }
}

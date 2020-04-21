using System;

namespace PandaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda p1= new Panda ("Pan Dee");
            Panda p2= new Panda ("Pan Dah");
            Panda p3 = new Panda("Pan Dee Tah");
          
            for (int i = 0; i < 5; i++)
            {
                Panda p = new Panda("Pan Dah For");
                Console.WriteLine(p.Name);
               
            }
           
            Console.WriteLine (p1.Name); //Pan Dee
            Console.WriteLine (p2.Name); //Pan Dah
            Console.WriteLine (p3.Name);
    
            Console.WriteLine(Panda.Population);//2
        }
    }
}

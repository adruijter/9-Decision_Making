using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een raadspelletje waarbij de speler een getal moet raden onder de 25.
             * je mag natuurlijk ook een ander getal nemen.
             * Als het getal niet correct is geraden mag de persoon het nog een beperkt aantal
             * keren proberen. Na dit aantal stopt het spel.
             */

            Random random = new Random();
            double willekeurigGetal = random.NextDouble() * 25;
            short afgerondGetal = (short)Math.Round(willekeurigGetal);
            Console.WriteLine("Dit is het random getal: {0}", afgerondGetal.ToString());


            
            Console.ReadLine();
        }
    }
}

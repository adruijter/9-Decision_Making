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
            short teRadenGetal = 13;
            short getalVanSpeler;

            Random random = new Random();
            double willekeurigGetal = random.NextDouble() * 25;
            short afgerondGetal = (short)Math.Round(willekeurigGetal);

            // Vraag om invoer
            Console.WriteLine("Geef een getal tussen de 0 en 25\nu heeft 3 kansen om te winnen\n");

            Console.Write("Uw eerste getal: ");
            
            // Stop de ingevoerde waarde in een string genaamd input
            string input  =  Console.ReadLine();

            // Cast de string naar een short variabele
            getalVanSpeler = Convert.ToInt16(input);

            if (getalVanSpeler != teRadenGetal)
            {
                Console.WriteLine("++++++++++++++++++++++++");
                Console.WriteLine("U heeft het getal niet goed geraden.\nU heeft {0} ingevoerd," +
                                  "\nGeef opnieuw een getal tussen de 0 en de 25\n", getalVanSpeler);
                
                Console.Write("Uw tweede getal: ");

                // Stop de ingevoerde waarde in een string genaamd input
                input  =  Console.ReadLine();

                // Cast de string naar een short variabele
                getalVanSpeler = Convert.ToInt16(input);

                if (getalVanSpeler != teRadenGetal)
                {
                    Console.WriteLine("++++++++++++++++++++++++");
                    Console.WriteLine("U heeft het getal niet goed geraden.\nU heeft {0} ingevoerd," +
                                      "\nGeef opnieuw een getal tussen de 0 en de 25\n", getalVanSpeler);

                    Console.Write("Uw derde en laatste getal: ");

                    // Stop de ingevoerde waarde in een string genaamd input
                    input = Console.ReadLine();

                    // Cast de string naar een short variabele
                    getalVanSpeler = Convert.ToInt16(input);

                    if (getalVanSpeler != teRadenGetal)
                    {
                        Console.WriteLine("++++++++++++++++++++++++++");
                        Console.WriteLine("U heeft het getal de derde keer niet goed geraden.\nU heeft {0} ingevoerd," +
                                          "We stoppen het spel.\nHet getal was: {1}", getalVanSpeler, teRadenGetal);
                        // Stop de ingevoerde waarde in een string genaamd input
                    }
                    else
                    {
                        Console.WriteLine("Gefeliciteerd u heeft het getal {0} in drie keer geraden", teRadenGetal);
                    }
                }
                else
                {
                    Console.WriteLine("Gefeliciteerd u heeft het getal {0} in twee keer geraden", teRadenGetal);
                }
            }
            else
            {
                Console.WriteLine("Gefeliciteerd u heeft het getal {0} in een keer geraden", teRadenGetal);
            }
           


            
            Console.ReadLine();
        }
    }
}

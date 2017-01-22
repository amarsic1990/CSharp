using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KarteLibrary;

namespace FlushRuka
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Deck deckZaIgru = new Deck();
                deckZaIgru.Shuffle();
                bool jeBoja = false;
                Suit boja;
                int indexRuke = 0;

                for (int ruka = 0; ruka < 10; ruka++)
                {
                    boja = deckZaIgru.GetCard(ruka * 5).suit;
                    jeBoja = true;

                    for (int karta = 1; karta < 5; karta++)
                    {
                        if(deckZaIgru.GetCard(ruka * 5 + karta).suit != boja)
                        {
                            jeBoja = false;
                        }
                    }

                    if (jeBoja)
                    {
                        Console.WriteLine("Flush");

                        indexRuke = ruka;

                        for (int karta = 0; karta < 5; karta++)
                        {
                            Console.WriteLine(deckZaIgru.GetCard(indexRuke * 5 + karta));
                        }
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("nema Flush-a :(");
                    }
                }
            }

        }
    }
}

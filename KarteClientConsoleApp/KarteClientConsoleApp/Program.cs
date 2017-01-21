using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KarteLibrary;

namespace KarteClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();

            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.WriteLine(tempCard.ToString());
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            myDeck.Shuffle();
            for(int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.WriteLine(tempCard.ToString());
            }
            Console.ReadKey();

        }
    }
}

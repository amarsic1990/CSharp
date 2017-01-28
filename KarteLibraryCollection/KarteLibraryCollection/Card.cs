using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarteLibraryCollection
{
    public class Card
    {
        public readonly Suit suit;
        public readonly Rank rank;

        private Card() { }

        public Card(Suit newsSuit, Rank newRank)
        {
            suit = newsSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarteLibraryCollection
{
    public class Deck
    {
        private Cards dekKarata = new Cards();
        public Deck()
        {
            for(int suitVrij = 0; suitVrij < 4; suitVrij++)
            {
                for(int rankVrij = 0; rankVrij < 13; rankVrij++)
                {
                    dekKarata.DodajKartu(new Card((Suit)suitVrij, (Rank)rankVrij));
                }
            }
        }

        public Card VratiKartu(int brojKarte)
        {
            if (brojKarte >= 0 && brojKarte <= 51)
            {
                return dekKarata[brojKarte];
            }
            else
            {
                throw new ArgumentOutOfRangeException("broj karte mora biti izmedu 0 i 51!!!");
            }
        }

        public void IzmjesajKarte()
        {
            Cards noviDek = new Cards();
            bool[] dodjeljeno = new bool[52];
            Random slucajniBroj = new Random();
            int brojKarte = 0;

            for (int i = 0; i < 52; i++)
            {
                bool kartaDodjeljena = false;
                while (kartaDodjeljena == false)
                {
                    brojKarte = slucajniBroj.Next(52);
                    if(dodjeljeno[brojKarte] == false)
                    {
                        noviDek.DodajKartu(dekKarata[brojKarte]);
                        dodjeljeno[brojKarte] = true;
                        kartaDodjeljena = true;
                    }
                }
            }
            noviDek.KopirajKarte(dekKarata);
        }
    }
}

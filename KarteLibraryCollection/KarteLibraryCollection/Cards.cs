using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace KarteLibraryCollection
{
    public class Cards : CollectionBase
    {
        public void DodajKartu(Card novaKarta)
        {
            List.Add(novaKarta);
        }

        public void UkloniKartu(Card staraKarta)
        {
            List.Remove(staraKarta);
        }

        public Card this[int kartaIndeks]
        {
            get { return (Card)List[kartaIndeks]; }
            set { List[kartaIndeks] = value; }
        }


        public void KopirajKarte(Cards stariDek)
        {
            for(int i = 0; i < 52; i++)
            {
                stariDek[i] = this[i];
            }
        }

        public bool SadrziKartu(Card karta) => InnerList.Contains(karta);
    }
}

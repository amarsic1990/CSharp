using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KarteLibraryCollection;

namespace KarteLibraryCollectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck igrajuciDek = new Deck();

            //for (int i = 0; i < 52; i++)
            //{
            //    Console.WriteLine(igrajuciDek.VratiKartu(i));
            //}

            //Console.ReadKey();

            igrajuciDek.IzmjesajKarte();

            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(igrajuciDek.VratiKartu(i));
            }
            Console.ReadKey();
        }
    }
}

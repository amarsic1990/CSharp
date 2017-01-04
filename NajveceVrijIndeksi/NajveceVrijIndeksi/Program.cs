using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajveceVrijIndeksi
{
    class Program
    {
        static int brojNajVrij;

        static void Main(string[] args)
        {
            int[] indeksPoz;
            int[] arrayBrojeva = { 0, -11, 22, 1, 2, 8, 92, 1, 54, 92, 85, 92, 63, 89, 92 };

            Console.WriteLine($"Najveci broj u array-u je: {MaxVrijIndeksi(arrayBrojeva, out indeksPoz)}, broj se ponavlja ukupno: {brojNajVrij} i nalazi se na pozicijama:");

            foreach(int pozicija in indeksPoz)
            {
                Console.WriteLine(pozicija);
            }
        }

        static int MaxVrijIndeksi(int[] intArray, out int[] indeksi)
        {
            int maxVrij = intArray[0];
            indeksi = new int[1];
            indeksi[0] = 0;
            brojNajVrij = 1;

            for (int i = 1; i < intArray.Length; i++)
            {
                if ( intArray[i] > maxVrij)
                {
                    maxVrij = intArray[i];
                    indeksi = new int[1] { i };
                    brojNajVrij = 1;
                }
                else if (intArray[i] == maxVrij)
                {                    
                    brojNajVrij++;

                    int[] stariIndeksi = indeksi;

                    indeksi = new int[brojNajVrij];

                    stariIndeksi.CopyTo(indeksi, 0);

                    indeksi[brojNajVrij - 1] = i;

                }
            }
            return maxVrij;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DebugWriteLine
{
    class Program
    {
        static int MaksVrij(int[] intArray, out int[] maksVrijIndeks)
        {
            int brojMaksVrij = 1;
            int maksVrij = intArray[0];
            maksVrijIndeks = new int[1] { 0 };

            Debug.WriteLine($"maksimalna vrijednost dodjeljena prvom elementu u arrayu: {maksVrij}");

            Debug.WriteLine("Pocetak trazenja maksimalne vrijednosti");

            for (int i = 1; i < intArray.Length; i++)
            {
                Debug.WriteLine($"Gledam element na indeksu: {i}");
                if (intArray[i] > maksVrij)
                {
                    brojMaksVrij = 1;
                    maksVrij = intArray[i];
                    maksVrijIndeks = new int[1] { i };
                    Debug.WriteLine($"Pronadena nova maksimalna vrijednost: {maksVrij} indeks: {maksVrijIndeks[0]}");
                }
                else if(intArray[i] == maksVrij)
                {
                    brojMaksVrij++;
                    int[] stariIndeksi = maksVrijIndeks;
                    maksVrijIndeks = new int[brojMaksVrij];
                    stariIndeksi.CopyTo(maksVrijIndeks, 0);
                    maksVrijIndeks[brojMaksVrij - 1] = i;
                    Debug.WriteLine($"Pronadena dupla maksimalna vrijednost {maksVrij} indeks: {i}");

                }
            }
            Debug.WriteLine($"Maksimalna vrijednost {maksVrij} pronadena, ponavlja se {brojMaksVrij} puta");
            Debug.WriteLine("Trazenje maksimalne vrijednosti zavrseno!!!");
            return maksVrij;
        }
        static void Main(string[] args)
        {
            int[] testniArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };

            int[] maxInd;
            int maxVrij = MaksVrij(testniArray, out maxInd);

            Console.WriteLine($"maksimalna vrijednost {maxVrij} na {(maxInd.Length > 1 ? "indeksima:" : "indeksu:")}");

            foreach(int indeks in maxInd)
            {
                Console.WriteLine(indeks);
            }
            Console.ReadKey();
        }
    }
}

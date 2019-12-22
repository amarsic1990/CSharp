using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnikOcjena
{
    class Program
    {
        static void Main(string[] args)
        {

            Dnevnik dnevnik = new Dnevnik();

            dnevnik.DodajOcjenu(4);
            dnevnik.DodajOcjenu(2);
            dnevnik.DodajOcjenu(5);
            dnevnik.DodajOcjenu(1);
            dnevnik.DodajOcjenu(1);
            dnevnik.DodajOcjenu(3);

            Statistika statistika = dnevnik.IzracunajStatistiku();

            Console.WriteLine($"prosjećna ocjena je: {statistika.prosjecnaOcjena} najmanja ocjena je: {statistika.najmanjaOcjena}, najveća ocjena je: {statistika.najvecaOcjena}");

            Console.ReadKey();

        }
    }
}

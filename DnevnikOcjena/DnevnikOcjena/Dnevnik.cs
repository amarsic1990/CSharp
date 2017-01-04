using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnikOcjena
{
    class Dnevnik
    {

        List<int> ocjene = new List<int>();

        public void DodajOcjenu(int ocjena)
        {
            ocjene.Add(ocjena);
        }

        public Statistika IzracunajStatistiku()
        {
            Statistika stat = new Statistika();

            double zbrojOcjena = 0;
            foreach(int ocjena in ocjene)
            {
                zbrojOcjena += ocjena;
                stat.najmanjaOcjena = Math.Min(stat.najmanjaOcjena, ocjena);
                stat.najvecaOcjena = Math.Max(stat.najvecaOcjena, ocjena);
            }
            stat.prosjecnaOcjena = zbrojOcjena / ocjene.Count;
            return stat;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppBrojSamogl
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] samoglasnici = { 'a', 'e', 'i', 'o', 'u' };
            string ime = "ecpswnidcmqeklegza";
            int brojSamoglasnika = 0;

            for (int i = 0; i < samoglasnici.Length; i++)
            {
                for (int j = 0; j < ime.Length; j++)
                {
                    if (ime[j] == samoglasnici[i])
                    {
                        brojSamoglasnika += 1;
                    }
                }
            }
            Console.WriteLine($"broj samoglasnika u rijeci: { brojSamoglasnika}");
            Console.ReadKey();
        }
    }
}

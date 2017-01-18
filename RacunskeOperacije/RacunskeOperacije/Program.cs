using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacunskeOperacije
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prviBrDod = false;
            bool drugiBrDod = false;

            int prviBroj = 0 , drugiBroj = 0;

            while (prviBrDod == false)
            {
                try
                {
                    Console.WriteLine("Molim unesite prvi broj:");
                    prviBroj = Convert.ToInt32(Console.ReadLine());
                    prviBrDod = true;
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (drugiBrDod == false)
            {
                try
                {
                    Console.WriteLine("Molim unesite drugi broj");
                    drugiBroj = Convert.ToInt32(Console.ReadLine());
                    drugiBrDod = true;
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Zbrajanje: {prviBroj +drugiBroj}");
            Console.WriteLine($"Oduzimanje: {prviBroj - drugiBroj}");
            Console.WriteLine($"Mnozenje: {prviBroj * drugiBroj}");
            Console.WriteLine($"Djeljenje: {prviBroj / drugiBroj}");
            Console.WriteLine($"Ostatak djeljenja: {prviBroj % drugiBroj}");
            Console.WriteLine($"Potenciranje: {Math.Pow(prviBroj, drugiBroj)}");
            Console.ReadKey();
        }
    }
}

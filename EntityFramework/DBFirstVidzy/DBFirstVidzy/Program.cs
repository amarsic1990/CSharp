using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstVidzy
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new VidzyDbContext();
            //context.AddVideo("Parada", DateTime.Now, "Comedy");
            //context.AddVideo("Maršal", DateTime.Now, "Comedy");
            //context.AddVideo("Kako je poceo rat na mom otoku", DateTime.Now, "Action");

            //context.AddVideo("žikina dinastija", DateTime.Now, 1);


            context.AddVideo("Kad mrtvi zapjevaju", DateTime.Now, 1,2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var einfacherSchrank = Schrank.BaueSchrank()
                                          .MitBöden(2)
                                          .MitTüren(4)
                                          .MitOberfläche(Schrank.Oberflächenart.Lackiert)
                                          .InFarbe("Gelb")
                                          .MitMetallschiene(true)
                                          .Konstruiere();


            var komplexer = Schrank.BaueSchrank()
                                   .MitBöden(5)
                                   .MitTüren(7)
                                   .MitOberfläche(Schrank.Oberflächenart.Gewachst)
                                   .MitMetallschiene(true)
                                   .MitKleiderstange(true)
                                   .Konstruiere();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

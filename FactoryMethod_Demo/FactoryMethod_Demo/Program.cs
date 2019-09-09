using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kantine k = new Kantine();

            IEssen lecker = k.GibEssen();

            lecker.Beschreibung();

            IEssen lecker2 = k.GibEssen(new DateTime(1848, 3, 22, 14, 52, 12));

            if (lecker2 is Mittagessen mittag)
            {
                mittag.Demo12345();
            }

            lecker2.Beschreibung();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AufgabenListe meineAufgaben = new AufgabenListe();
            meineAufgaben.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 1",IstErledigt=true });
            meineAufgaben.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 2", IstErledigt = true });
            meineAufgaben.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 3", IstErledigt = true });
            meineAufgaben.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 4", IstErledigt = true });

            AufgabenListe mf2 = new AufgabenListe();
            mf2.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 5", IstErledigt = true });
            mf2.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 6", IstErledigt = true });
            mf2.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 7", IstErledigt = true });
            mf2.Liste.Add(new Einzelaufgabe { Beschreibung = "Demo 8", IstErledigt = true });

            meineAufgaben.Liste.Add(mf2);

            Console.WriteLine(meineAufgaben.SindAlleErledigt);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

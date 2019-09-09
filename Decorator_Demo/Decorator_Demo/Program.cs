using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var lecker = new Ananas(new Käse(new Salami(new Salami(new Pizza()))));

            Console.WriteLine(lecker.Beschreibung);
            Console.WriteLine(lecker.Preis);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // MEF:
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            Taschenrechner tr = new Taschenrechner();

            container.ComposeParts(tr);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

    class Taschenrechner
    {
        [ImportMany(typeof(IRechenart))]
        public IRechenart[] MeineRechnearten { get; set; }

        [Import("Multi")]
        public object BasisRechnung { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Taschenrechner.Logik.Class1;
using Taschenrechner.Logik;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;

namespace SOLID_Taschenrechner
{
    partial class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            var parser = new RegexParser();
            var calculator = new MEFCalculator();

            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(calculator); // add, sub...
            new KonsolenUI(parser,calculator).Start();
            // Aufgabe: Klasse Multiplikation und Division erstellen und den TR mit dem Feature erweitern
        }
    }
}

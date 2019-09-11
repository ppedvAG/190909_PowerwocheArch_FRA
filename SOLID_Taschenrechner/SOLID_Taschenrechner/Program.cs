using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Taschenrechner.Logik;
using Taschenrechner.Rechenmodule;
using static Taschenrechner.Logik.Class1;

namespace SOLID_Taschenrechner
{
    partial class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            var parser = new RegexParser();
            var calculator = new ModularCalculator(new Addition(), new Subtraktion(),new Mulitplikation(),new Division());

            new KonsolenUI(parser,calculator).Start();
            // Aufgabe: Klasse Multiplikation und Division erstellen und den TR mit dem Feature erweitern
        }
    }
}

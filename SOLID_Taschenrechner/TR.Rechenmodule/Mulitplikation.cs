using System.ComponentModel.Composition;
using Taschenrechner.Domain;

namespace Taschenrechner.Rechenmodule
{
    [Export(typeof(IRechenart))]

    public class Mulitplikation : IRechenart
    {
        public string Operator => "*";

        public int Berechne(int z1, int z2)
        {
            return z1 * z2;
        }
    }
}

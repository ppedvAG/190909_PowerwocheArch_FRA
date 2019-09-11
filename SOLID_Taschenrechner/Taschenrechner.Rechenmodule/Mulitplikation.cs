using Taschenrechner.Domain;

namespace Taschenrechner.Rechenmodule
{
    public class Mulitplikation : IRechenart
    {
        public string Operator => "*";

        public int Berechne(int z1, int z2)
        {
            return z1 * z2;
        }
    }
}

using Taschenrechner.Domain;

namespace Taschenrechner.Rechenmodule
{
    public class Subtraktion : IRechenart
    {
        public string Operator => "-";
        public int Berechne(int z1, int z2) => z1 - z2;
    }
}

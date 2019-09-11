using System;
using Taschenrechner.Domain;

namespace Taschenrechner.Rechenmodule
{
    public class Division : IRechenart
    {
        public string Operator => "/";

        public int Berechne(int z1, int z2) => Convert.ToInt32(z1 / z2);

    }
}

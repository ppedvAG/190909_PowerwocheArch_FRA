using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.ComponentModel.Composition;

namespace Logik
{
    [Export(typeof(IRechenart))]
    public class Addition : IRechenart
    {
        public int Berechne(int z1, int z2)
        {
            return z1 + z2;
        }
    }

    [Export(typeof(IRechenart))]
    public class Subtraktion : IRechenart
    {
        public int Berechne(int z1, int z2)
        {
            return z1 - z2;
        }
    }

    [Export("Multi")]
    public class Multiplikation : IRechenart
    {
        public int Berechne(int z1, int z2)
        {
            return z1 - z2;
        }
    }
}

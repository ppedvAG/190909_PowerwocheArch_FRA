using System;
using System.Linq;
using Widerstandsmessung.Domain;

namespace Widerstand.Logic.KT
{
    public class KTMessTechnik : IMesstechnikV2
    {
        public ISTWiderstand Berechne(SOLLWiderstand soll)
        {
            ISTWiderstand ist = new ISTWiderstand();

            ist.UV = soll.UV * 5.2;
            ist.VW = soll.VW * 2.8;
            ist.UW = soll.UW * 0.333;

            ist.Mittelwert = (ist.UV + ist.VW + ist.UW) / 3;
            return ist;
        }

        public ISTWiderstand Spitzenwert(SOLLWiderstand soll)
        {
            var ist = Berechne(soll);
            ist.Spitzenwert = new double[] { ist.UV, ist.UW, ist.VW }.Max();
            return ist;
        }
    }
}

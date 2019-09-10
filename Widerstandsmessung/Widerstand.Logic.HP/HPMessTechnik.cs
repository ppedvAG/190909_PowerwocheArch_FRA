using System;
using Widerstandsmessung.Domain;

namespace Widerstand.Logic.HP
{
    public class HPMessTechnik : IMesstechnik
    {
        public ISTWiderstand Berechne(SOLLWiderstand soll)
        {
            ISTWiderstand ist = new ISTWiderstand();

            ist.UV = soll.UV * 1.2;
            ist.VW = soll.VW * 0.8;
            ist.UW = soll.UW * 1.111;

            ist.Mittelwert = (ist.UV + ist.VW + ist.UW) / 3;
            return ist;
        }
    }
}

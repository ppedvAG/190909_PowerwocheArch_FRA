using System;
using Widerstandsmessung.Domain;

namespace Widerstand.Logic.NI
{
    public class NIMessTechnik : IMesstechnik
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
    }
}

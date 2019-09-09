using System;

namespace Fassade_Demo
{
    class LagerService
    {
        private IOutput defaultOutput;

        public LagerService(IOutput defaultOutput)
        {
            this.defaultOutput = defaultOutput;
        }

        public bool IstProduktAufLager(string produktcode)
        {
            return true; // immer da ;)
        }
        public void ProduktNachbestellen(string produktcode)
        {
            defaultOutput.WriteOutput($"Produkt '{produktcode}' wird nachbestellt...");
        }
    }
}

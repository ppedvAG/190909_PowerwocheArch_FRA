using System;

namespace Fassade_Demo
{
    class RechnungsService
    {
        private IOutput defaultOutput;

        public RechnungsService(IOutput defaultOutput)
        {
            this.defaultOutput = defaultOutput;
        }

        public bool SindRechnungenNochOffen(int kundenID)
        {
            return false; // kunde darf immer bestellen ;)
        }
        public void BezahlvorgangStarten(int kundenID)
        {
            defaultOutput.WriteOutput("Rechnung wird bezahlt");
        }
    }
}

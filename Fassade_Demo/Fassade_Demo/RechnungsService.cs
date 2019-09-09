using System;

namespace Fassade_Demo
{
    class RechnungsService
    {
        public bool SindRechnungenNochOffen(int kundenID)
        {
            return false; // kunde darf immer bestellen ;)
        }
        public void BezahlvorgangStarten(int kundenID)
        {
            Console.WriteLine("Rechnung wird bezahlt");
        }
    }
}

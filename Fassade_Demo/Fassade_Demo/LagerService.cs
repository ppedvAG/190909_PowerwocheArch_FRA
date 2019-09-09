using System;

namespace Fassade_Demo
{
    class LagerService
    {
        public bool IstProduktAufLager(string produktcode)
        {
            return true; // immer da ;)
        }
        public void ProduktNachbestellen(string produktcode)
        {
            Console.WriteLine($"Produkt '{produktcode}' wird nachbestellt...");
        }
    }
}

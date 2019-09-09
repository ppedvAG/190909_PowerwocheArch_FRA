using System;

namespace FactoryMethod_Demo
{
    class KeinEssen : IEssen
    {
        public void Beschreibung()
        {
            Console.WriteLine("Kantine ist zu !");
        }
    }
}

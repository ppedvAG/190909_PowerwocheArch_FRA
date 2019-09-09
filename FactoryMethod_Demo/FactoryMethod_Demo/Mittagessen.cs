using System;

namespace FactoryMethod_Demo
{
    class Mittagessen : IEssen
    {
        public void Beschreibung()
        {
            Console.WriteLine("Braten mit grüner Sauce");
        }
    }
}

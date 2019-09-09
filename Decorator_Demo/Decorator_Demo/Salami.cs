using System;

namespace Decorator_Demo
{
    class Salami : Dekorator
    {
        public Salami(IComponent Parent) : base(Parent){}

        public override decimal Preis { get => Parent.Preis + 2.5m ; set => throw new NotImplementedException(); }
        public override string Beschreibung { get => Parent.Beschreibung + "Salami "; set => throw new NotImplementedException(); }
    }
}

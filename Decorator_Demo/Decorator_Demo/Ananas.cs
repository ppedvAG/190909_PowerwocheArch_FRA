using System;

namespace Decorator_Demo
{
    class Ananas : Dekorator
    {
        public Ananas(IComponent Parent) : base(Parent){}

        public override decimal Preis { get => Parent.Preis + 1.33m ; set => throw new NotImplementedException(); }
        public override string Beschreibung { get => Parent.Beschreibung + "Ananas "; set => throw new NotImplementedException(); }
    }
}

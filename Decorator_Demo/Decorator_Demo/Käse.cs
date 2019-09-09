using System;

namespace Decorator_Demo
{
    class Käse : Dekorator
    {
        public Käse(IComponent Parent) : base(Parent) { }

        public override decimal Preis { get => Parent.Preis + 0.5m; set => throw new NotImplementedException(); }
        public override string Beschreibung { get => Parent.Beschreibung + "Käse "; set => throw new NotImplementedException(); }
    }
}

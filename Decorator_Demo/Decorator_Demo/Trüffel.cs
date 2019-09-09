using System;

namespace Decorator_Demo
{
    class Trüffel : Dekorator
    {
        public Trüffel(IComponent Parent) : base(Parent) { }

        public override decimal Preis { get => Parent.Preis + 20.5m; set => throw new NotImplementedException(); }
        public override string Beschreibung { get => Parent.Beschreibung + "Trüffel "; set => throw new NotImplementedException(); }
    }
}

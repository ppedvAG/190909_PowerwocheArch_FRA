namespace Decorator_Demo
{
    abstract class Dekorator : IComponent
    {
        public Dekorator(IComponent Parent)
        {
            this.Parent = Parent;
        }

        public IComponent Parent { get; set; }

        public abstract decimal Preis { get; set; }
        public abstract string Beschreibung { get; set; }
    }
}

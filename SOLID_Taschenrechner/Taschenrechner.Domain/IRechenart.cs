namespace Taschenrechner.Domain
{
    public interface IRechenart
    {
        string Operator { get; }
        int Berechne(int z1, int z2);
    }
}

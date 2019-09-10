namespace Widerstandsmessung.Domain
{
    public interface IMesstechnikV2 : IMesstechnik
    {
        ISTWiderstand Spitzenwert(SOLLWiderstand soll);
    }

}

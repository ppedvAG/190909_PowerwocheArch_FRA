namespace Widerstandsmessung.Domain
{
    public interface IMesstechnik
    {
        ISTWiderstand Berechne(SOLLWiderstand soll);
    }

}

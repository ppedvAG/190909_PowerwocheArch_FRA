using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Demo
{
    interface IComponent
    {
        decimal Preis { get;}
        string Beschreibung { get; }
    }
}

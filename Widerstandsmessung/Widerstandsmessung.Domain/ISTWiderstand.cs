using System;

namespace Widerstandsmessung.Domain
{

    public class ISTWiderstand : Entity
    {
        public double UV { get; set; }
        public double UW { get; set; }
        public double VW { get; set; }
        public double Mittelwert { get; set; }
    }

}

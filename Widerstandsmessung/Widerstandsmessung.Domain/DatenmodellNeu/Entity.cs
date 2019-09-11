using System;
using System.Collections.Generic;
using System.Text;

namespace Widerstandsmessung.Domain.DatenmodellNeu
{
    public abstract class Entity
    {
        public int ID { get; set; }
    }

    public class Spannung : Entity
    {
        public double Spannung1 { get; set; }
        public double Spannung2 { get; set; }
        public double Spannung3 { get; set; }
    }
    public class SollWiderstand : Entity
    {
        public double UV { get; set; }
        public double UW { get; set; }
        public double VW { get; set; }
    }
    public class IstWiderstand : Entity
    {
        public double UV { get; set; }
        public double UW { get; set; }
        public double VW { get; set; }
        public double Mittelwert { get; set; }
    }
    public class SollWerte : Entity
    {
        public virtual SollWiderstand Widerstand { get; set; }
        public virtual Spannung Spannungswerte { get; set; }
    }
    public class IstWerte : Entity
    {
        public virtual IstWiderstand Widerstand { get; set; }
    }
}

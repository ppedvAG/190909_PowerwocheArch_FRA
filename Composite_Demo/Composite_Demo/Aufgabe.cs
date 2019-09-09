using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Composite_Demo
{
    abstract class Aufgabe
    {
        public string Beschreibung { get; set; }
        public virtual bool IstErledigt { get; set; }

        public void AufgabeErledigen()
        {
            Thread.Sleep(5000);
            IstErledigt = true;
        }
    }

    class Einzelaufgabe : Aufgabe
    {
        public DateTime Deadline { get; set; }
    }

    class AufgabenListe : Aufgabe
    {
        public List<Aufgabe> Liste { get; set; } = new List<Aufgabe>();

        public override bool IstErledigt // True wenn alle in der Liste bei "IstErledigt" true sind
        {
            get => Liste.All(x => x.IstErledigt == true);
            set
            {
                foreach (var item in Liste)
                {
                    item.IstErledigt = value;
                }
            }
        }
    }


}

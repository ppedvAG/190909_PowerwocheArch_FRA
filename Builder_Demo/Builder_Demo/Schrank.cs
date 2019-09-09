using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Demo
{
    class Schrank
    {
        private Schrank() { }

        public int AnzahlTüren { get; set; }
        public int AnzahlBöden { get; set; }
        public string Farbe { get; set; }
        public enum Oberflächenart { Unbehandelt, Gewachst,Lackiert}
        public Oberflächenart Oberfläche { get; set; }
        public bool Kleiderstange { get; set; }
        public bool Metallschiene { get; set; }

        public static SchrankBuilder BaueSchrank() => new SchrankBuilder();

        public class SchrankBuilder // nested class
        {
            public SchrankBuilder()
            {
                zuBauenderSchrank = new Schrank();
            }
            private Schrank zuBauenderSchrank;

            public SchrankBuilder MitBöden(int anzahl)
            {
                if (anzahl >= 0 && anzahl <= 6)
                    zuBauenderSchrank.AnzahlBöden = anzahl;
                else
                    throw new ArgumentException("Die Anzahl der Böden ist ungültig");
                return this;
            }
            public SchrankBuilder MitTüren(int anzahl)
            {
                if (anzahl >= 2 && anzahl <= 7)
                    zuBauenderSchrank.AnzahlTüren = anzahl;
                else
                    throw new ArgumentException("Die Anzahl der Türen ist ungültig");
                return this;
            }
            public SchrankBuilder MitOberfläche(Oberflächenart oberflächenart)
            {
                zuBauenderSchrank.Oberfläche = oberflächenart;
                return this;
            }
            public SchrankBuilder InFarbe(string farbe)
            {
                if (zuBauenderSchrank.Oberfläche == Oberflächenart.Lackiert)
                    zuBauenderSchrank.Farbe = farbe;
                else
                    throw new ArgumentException("Es darf nur ein lackierter Schrank eingefärbt werden !");
                return this;
            }
            public SchrankBuilder MitMetallschiene(bool schiene)
            {
                zuBauenderSchrank.Metallschiene = schiene;
                return this;
            }
            public SchrankBuilder MitKleiderstange(bool stange)
            {
                zuBauenderSchrank.Kleiderstange = stange;
                return this;
            }

            public Schrank Konstruiere()
            {
                return zuBauenderSchrank;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fassade_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MailService ms = new MailService();
            LagerService ls = new LagerService();
            RechnungsService rs = new RechnungsService();
            VersandService vs = new VersandService();

            if(rs.SindRechnungenNochOffen(1234) == false)
            {
                if(ls.IstProduktAufLager("abcde") == true)
                {
                    rs.BezahlvorgangStarten(1234);
                    ls.ProduktNachbestellen("abcde");
                    vs.VersendeMitDHL();
                    ms.BestätigungsMailSenden();
                }
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fassade_Demo
{
    class Amazon
    {
        public Amazon()
        {
            mailService  = new MailService(defaultOutput);
            lagerService  = new LagerService(defaultOutput);
            rechnungsService  = new RechnungsService(defaultOutput);
            versandService  = new VersandService(defaultOutput);
        }
        IOutput defaultOutput = new DebugOutput();

        private MailService mailService;
        private LagerService lagerService;
        private RechnungsService rechnungsService;
        private VersandService versandService;

        public void BestelleWas()
        {
            if (rechnungsService.SindRechnungenNochOffen(1234) == false)
            {
                if (lagerService.IstProduktAufLager("abcde") == true)
                {
                    rechnungsService.BezahlvorgangStarten(1234);
                    lagerService.ProduktNachbestellen("abcde");
                    versandService.VersendeMitDPD();
                    mailService.BestätigungsMailSenden();
                }
            }
        }
    }
}

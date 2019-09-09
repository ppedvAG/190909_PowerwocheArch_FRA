using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fassade_Demo
{
    class MailService
    {
        private IOutput defaultOutput;

        public MailService(IOutput defaultOutput)
        {
            this.defaultOutput = defaultOutput;
        }

        public void BestätigungsMailSenden()
        {
            defaultOutput.WriteOutput("Bestätigungsmail wird gesendet...");
        }
    }
}

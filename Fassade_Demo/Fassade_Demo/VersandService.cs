using System;

namespace Fassade_Demo
{
    class VersandService
    {
        private IOutput defaultOutput;

        public VersandService(IOutput defaultOutput)
        {
            this.defaultOutput = defaultOutput;
        }

        //public void VersendeMitDHL()
        //{
        //    Console.WriteLine("Paket wird mit DHL versendet");
        //}

        public void VersendeMitDPD()
        {
            defaultOutput.WriteOutput("Paket wird mit DPD versendet");
        }
    }
}

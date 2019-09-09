using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fassade_Demo
{
    interface IOutput
    {
        void WriteOutput(string output);
    }

    class ConsoleOutput : IOutput
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }
    }

    class DebugOutput : IOutput
    {
        public void WriteOutput(string output)
        {
            Debug.WriteLine(output);
        }
    }

    // WindowsFOrms: MessageBox.SHow usw...
}

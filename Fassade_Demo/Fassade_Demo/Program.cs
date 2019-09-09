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
            Amazon a = new Amazon();
            a.BestelleWas();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

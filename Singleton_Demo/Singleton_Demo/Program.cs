using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Log("Hallo Welt");
            Logger.Instance.Log("Das ist ein Test");
            Logger.Instance.Log("Demo 1234");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

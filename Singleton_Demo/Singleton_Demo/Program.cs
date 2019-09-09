using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.For(0, 1000, i =>
              {
                  Thread.Sleep(10);
                  Logger.Instance.Log(i.ToString());
              });


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

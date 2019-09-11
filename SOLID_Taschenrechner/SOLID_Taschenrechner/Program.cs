using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie die Formel ein:");
            string input = Console.ReadLine(); // "2 + 2"

            string[] parts = input.Split();
            int z1 = Convert.ToInt32(parts[0]);
            string op = parts[1];
            int z2 = Convert.ToInt32(parts[2]);

            int result = 0;
            if (op == "+")
                result = z1 + z2;
            else if (op == "-")
                result = z1 - z2;
            // .....

            Console.WriteLine($"Das Ergebnis ist {result}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}

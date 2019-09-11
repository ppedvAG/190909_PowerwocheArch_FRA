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
            new KonsolenUI().Start();
        }

        public struct Formel
        {
            public int Operand1 { get; set; }
            public int Operand2 { get; set; }
            public string Operator { get; set; }
        }

        public class StringSplitParser
        {
            public Formel Parse(string input)
            {
                Formel output = new Formel();
                string[] parts = input.Split();
                output.Operand1 = Convert.ToInt32(parts[0]);
                output.Operator = parts[1];
                output.Operand2 = Convert.ToInt32(parts[2]);

                return output;
            }
        }

        public class IfCalculator
        {
            public int Calculate(Formel formel)
            {
                if (formel.Operator == "+")
                    return formel.Operand1 + formel.Operand2;
                else if (formel.Operator == "-")
                    return formel.Operand1 - formel.Operand2;
                else
                    throw new FormatException($"Operator '{formel.Operator}' wird nicht unterstützt");
            }
        }

        public class KonsolenUI
        {
            public void Start()
            {
                // UI
                Console.WriteLine("Bitte geben Sie die Formel ein:");
                string input = Console.ReadLine(); // "2 + 2"

                // Parsen
                var parser = new StringSplitParser();
                Formel formel = parser.Parse(input);

                // Berechnung
                var calculator = new IfCalculator();
                int result = calculator.Calculate(formel);
                // .....

                // UI
                Console.WriteLine($"Das Ergebnis ist {result}");

                Console.WriteLine("---ENDE---");
                Console.ReadKey();
            }
        }
    }
}

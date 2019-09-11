using System;
using Taschenrechner.Domain;

namespace SOLID_Taschenrechner
{
    partial class Program
    {
        public class KonsolenUI
        {
            public KonsolenUI(IParser parser, ICalculator calculator)
            {
                this.parser = parser;
                this.calculator = calculator;
            }
            private readonly IParser parser;
            private readonly ICalculator calculator;

            // App-Workflow
            public void Start()
            {
                // UI
                Console.WriteLine("Bitte geben Sie die Formel ein:");
                string input = Console.ReadLine(); // "2 + 2"

                // Parsen
                Formel formel = parser.Parse(input);

                // Berechnung
                int result = calculator.Calculate(formel);

                // UI
                Console.WriteLine($"Das Ergebnis ist {result}");

                Console.WriteLine("---ENDE---");
                Console.ReadKey();
            }
        }
    }
}

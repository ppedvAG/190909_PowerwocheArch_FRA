using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOLID_Taschenrechner
{
    class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            var parser = new RegexParser();
            var calculator = new IfCalculator();

            new KonsolenUI(parser,calculator).Start();
        }

        public struct Formel
        {
            public int Operand1 { get; set; }
            public int Operand2 { get; set; }
            public string Operator { get; set; }
        }


        public interface IParser
        {
            Formel Parse(string input);
        }
        public class StringSplitParser : IParser
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
        public class RegexParser : IParser
        {
            // https://regexr.com/
            public Formel Parse(string input)
            {
                Regex r = new Regex(@"(\d+)\s*(\D+?)\s*(\d+)");
                var result = r.Match(input);
                if (result.Success)
                {
                    Formel output = new Formel();
                    output.Operand1 = Convert.ToInt32(result.Groups[1].Value);
                    output.Operand2 = Convert.ToInt32(result.Groups[3].Value);
                    output.Operator = result.Groups[2].Value;
                    return output;
                }
                else
                    throw new FormatException("Die Eingabe hat das falsche Formel-Format");
            }
        }

        public interface ICalculator
        {
            int Calculate(Formel f);
        }
        public class IfCalculator : ICalculator
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

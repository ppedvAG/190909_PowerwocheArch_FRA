using System;
using System.Text.RegularExpressions;
using Taschenrechner.Domain;

namespace Taschenrechner.Logik
{
    public partial class Class1
    {
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
    }
}

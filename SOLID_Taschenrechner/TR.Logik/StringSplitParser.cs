using System;
using Taschenrechner.Domain;

namespace Taschenrechner.Logik
{
    public partial class Class1
    {
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
    }
}

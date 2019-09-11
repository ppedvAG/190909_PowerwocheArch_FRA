using System;
using Taschenrechner.Domain;

namespace Taschenrechner.Logik
{
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
}

using System;
using System.Linq;
using Taschenrechner.Domain;

namespace Taschenrechner.Logik
{
    public class ModularCalculator : ICalculator
    {
        public ModularCalculator(params IRechenart[] rechenarten)
        {
            this.rechenarten = rechenarten;
        }
        private readonly IRechenart[] rechenarten;

        public int Calculate(Formel f)
        {
            if (rechenarten.Any(x => x.Operator == f.Operator))
            {
                var rechenart = rechenarten.First(x => x.Operator == f.Operator);
                return rechenart.Berechne(f.Operand1, f.Operand2);
            }
            else
                throw new FormatException($"Der Operator {f.Operator} wird nicht unterstüzt");

        }
    }
}

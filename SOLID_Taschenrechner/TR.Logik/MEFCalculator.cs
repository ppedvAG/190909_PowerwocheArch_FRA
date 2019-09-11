using System;
using System.ComponentModel.Composition;
using System.Linq;
using Taschenrechner.Domain;

namespace Taschenrechner.Logik
{
    public class MEFCalculator : ICalculator
    {
        [ImportMany(typeof(IRechenart))]
        public IRechenart[] Rechenarten { get; set; }

        public int Calculate(Formel f)
        {
            if (Rechenarten.Any(x => x.Operator == f.Operator))
            {
                var rechenart = Rechenarten.First(x => x.Operator == f.Operator);
                return rechenart.Berechne(f.Operand1, f.Operand2);
            }
            else
                throw new FormatException($"Der Operator {f.Operator} wird nicht unterstüzt");

        }
    }
}

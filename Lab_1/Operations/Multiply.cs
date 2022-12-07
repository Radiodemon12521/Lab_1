using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Operations
{
    internal class Multiply : IOperation
    {
        public string Name { get; set; } = "Умножение";
        public double Calculate(double first, double second)
        {
            double res = first * second;
            return res;
        }
    }
}

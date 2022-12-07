using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_1.Operations;

internal class Divide : IOperation
{
    public string Name { get; set; } = "Деление";
    public double Calculate(double first, double second)
    {
        double res = first / second;
        return res;
    }
}

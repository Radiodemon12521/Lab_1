using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Operations
{
    public interface IOperation
    {
        public string Name { get; set; }

        public double Calculate(double first,double second);
    }
}

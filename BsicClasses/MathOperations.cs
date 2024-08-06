using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicClasses
{
    internal class MathOperations
    {
        public int Add(int x, int y)
        {
            Calculator calculator = new Calculator();
            return calculator.Add(x, y);
        }
    }
}

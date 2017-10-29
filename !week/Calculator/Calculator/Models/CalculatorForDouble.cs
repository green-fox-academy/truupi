using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Models
{
    class CalculatorForDouble:AbstractCalculator<double>
    {
        public override double Summarize(double input1, double input2)
        {
            return input1 + input2;
        }

        public override double Subtract(double input1, double input2)
        {
            return input1 - input2;
        }

        public override double Multiply(double input1, double input2)
        {
            return input1 * input2;
        }

        public override double Divide(double input1, double input2)
        {
            return input1 / input2;
        }
    }
}

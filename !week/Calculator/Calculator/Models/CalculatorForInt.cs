using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Models
{
    public class CalculatorForInt : AbstractCalculator<int>
    {
        public override int Summarize(int input1, int input2)
        {
            return input1 + input2;
        }

        public override int Subtract(int input1, int input2)
        {
            return input1 - input2;
        }

        public override int Multiply(int input1, int input2)
        {
            return input1 * input2;
        }

        public override int Divide(int input1, int input2)
        {
            return input1 / input2;
        }
    }
}

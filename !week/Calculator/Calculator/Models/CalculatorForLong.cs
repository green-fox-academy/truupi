using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Models
{
    public class CalculatorForLong : AbstractCalculator<long>
    {
        public override long Summarize(long input1, long input2)
        {
            return input1 + input2;
        }

        public override long Subtract(long input1, long input2)
        {
            return input1 - input2;
        }

        public override long Multiply(long input1, long input2)
        {
            return input1 * input2;
        }

        public override long Divide(long input1, long input2)
        {
            return input1 / input2;
        }
    }
}

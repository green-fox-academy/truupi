using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Models
{
    public class Calculation
    {
        private int intNumber1, intNumber2;

        public dynamic NumberTypeChecker(string inputNumber1, string inputNumber2, string arithmeticType)
        {
            if (inputNumber1.Contains('.') || inputNumber2.Contains('.'))
            {
                ArithmeticOperations<double> DoubleOperation = new ArithmeticOperations<double>(new CalculatorForDouble());

                List<double> DoubleNumbersList = new List<double>
                {
                    Convert.ToDouble(inputNumber1),
                    Convert.ToDouble(inputNumber2)
                };

                switch (arithmeticType)
                {
                    case "add":
                        return DoubleOperation.Summarize(DoubleNumbersList);
                    case "sub":
                        return DoubleOperation.Subtract(DoubleNumbersList);
                    case "div":
                        return DoubleOperation.Divide(DoubleNumbersList);
                    case "mul":
                        return DoubleOperation.Multiply(DoubleNumbersList);
                    default:
                        return "Operation failed!";
                }
            }
            else if (!Int32.TryParse(inputNumber1, out intNumber1) || !Int32.TryParse(inputNumber2, out intNumber2))
            {
                ArithmeticOperations<long> LongOperation = new ArithmeticOperations<long>(new CalculatorForLong());

                List<long> LongNumbersList = new List<long>
                {
                    Convert.ToInt64(inputNumber1),
                    Convert.ToInt64(inputNumber2)
                };

                switch (arithmeticType)
                {
                    case "add":
                        return LongOperation.Summarize(LongNumbersList);
                    case "sub":
                        return LongOperation.Subtract(LongNumbersList);
                    case "div":
                        return LongOperation.Divide(LongNumbersList);
                    case "mul":
                        return LongOperation.Multiply(LongNumbersList);
                    default:
                        return "Operation failed!";
                }
            }
            else
            {
                ArithmeticOperations<int> IntOperation = new ArithmeticOperations<int>(new CalculatorForInt());

                List<int> IntNumbersList = new List<int>
                {
                    Convert.ToInt32(inputNumber1),
                    Convert.ToInt32(inputNumber2)
                };

                switch (arithmeticType)
                {
                    case "add":
                        return IntOperation.Summarize(IntNumbersList);
                    case "sub":
                        return IntOperation.Subtract(IntNumbersList);
                    case "div":
                        return IntOperation.Divide(IntNumbersList);
                    case "mul":
                        return IntOperation.Multiply(IntNumbersList);
                    default:
                        return "Operation failed!";
                }
            }
        }
    }
}

using System.Collections.Generic;

namespace Calculator.Models
{
    public class ArithmeticOperations<T>
    {
        AbstractCalculator<T> GenericCalculator;

        public ArithmeticOperations(AbstractCalculator<T> GenericCalculator)
        {
            this.GenericCalculator = GenericCalculator;
        }
        public T Summarize(List<T> numbersList)
        {
            dynamic result = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                result = GenericCalculator.Summarize(result, numbersList[i]);
            }
            return result;
        }

        public T Subtract(List<T> numbersList)
        {
            dynamic result = numbersList[0];
            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                result = GenericCalculator.Subtract(result, numbersList[i + 1]);
            }
            return result;
        }

        public T Multiply(List<T> numbersList)
        {
            dynamic result = 1;
            for (int i = 0; i < numbersList.Count; i++)
            {
                result = GenericCalculator.Multiply(result, numbersList[i]);
            }
            return result;
        }

        public T Divide(List<T> numbersList)
        {
            dynamic result = 1;
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (result == 1)
                {
                    result = GenericCalculator.Divide(numbersList[i], result);
                }
                else
                {
                    result = GenericCalculator.Divide(result, numbersList[i]);
                }
            }
            return result;
        }
    }
}

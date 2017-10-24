using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FiboClass
    {
        public double GetNthFibonacci(double number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number <= 2)
            {
                return 1;
            }
            return GetNthFibonacci(number - 1) + GetNthFibonacci(number - 2);
        }
    }
}

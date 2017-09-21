using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciVarations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 9;
            Console.WriteLine(GetNthFibonacci(number));
            Console.ReadLine();
        }

        private static double GetNthFibonacci(double number)
        {
            double nthFibonacci = 0;
            if (number == 2)
            {
                return 1;
            }
            if (number <= 2)
            {
                return nthFibonacci;
            }
            return GetNthFibonacci(number - 1) + GetNthFibonacci(number - 2);
        }
    }
}
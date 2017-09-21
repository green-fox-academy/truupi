using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumDigitsRecursion(12345));
            Console.ReadLine();
        }

        static long sumDigitsRecursion(long baseNum)
        {
            if (baseNum == 0)
            {
                return 0;
            }
            else
            {
                return baseNum % 10 + sumDigitsRecursion(baseNum / 10);
            }
        }
    }
}

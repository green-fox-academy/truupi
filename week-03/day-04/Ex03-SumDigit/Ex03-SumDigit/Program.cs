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
            Console.WriteLine(sumDigitsRecursion(34454232423443534, 0));
            Console.ReadLine();
        }

        static long sumDigitsRecursion(long baseNum, long sumDigits)
        {
            if (baseNum == 0)
            {
                return sumDigits;
            }
            else
            {
                sumDigits = sumDigits + baseNum % 10;
                baseNum = baseNum / 10;
                return sumDigitsRecursion(baseNum, sumDigits);
            }
        }
    }
}

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
            Console.WriteLine(SumWithRecursion(5));
            Console.ReadLine();
        }

        public static int SumWithRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumWithRecursion(n - 1);
            }
        }
    }
}

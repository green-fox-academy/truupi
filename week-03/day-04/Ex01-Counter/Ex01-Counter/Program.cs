using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialWithRecursion(6);
            Console.ReadLine();
        }

        public static int FactorialWithRecursion(int n)
        {
            Console.WriteLine(n);
            if (n == 1)
            {
                return 1;
            }
            else
            {
               return FactorialWithRecursion(n - 1);
            }
        }
    }
}

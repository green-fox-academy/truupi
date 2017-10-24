using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Recursive(10, n);
            Console.ReadLine();
        }

        static int Recursive(int input, int n)
        {
            Console.WriteLine(n);
            if (n == input)
            {
                return 1;
            }
            else
            {
                return Recursive(input, n + 1);
            }
        }
    }
}

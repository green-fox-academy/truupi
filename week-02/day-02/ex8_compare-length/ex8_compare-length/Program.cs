using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_compare_length
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };

            if (p1.Length < p2.Length)
            {
                Console.WriteLine("P2 has more elements");
            }
            else Console.WriteLine("P1 has more elements");

            Console.ReadLine();
        }
    }
}

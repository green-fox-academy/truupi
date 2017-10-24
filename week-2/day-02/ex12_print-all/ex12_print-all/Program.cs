using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12_print_all
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };

            foreach (int element in af)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}

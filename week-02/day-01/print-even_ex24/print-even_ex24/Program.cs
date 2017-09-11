using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_even_ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 2;
            Console.WriteLine("Even numbers between 0 to 500\n");

            while (counter <= 500)
            {
                Console.WriteLine(counter);
                counter = counter + 2;
            }

            Console.ReadLine();
        }
    }
}

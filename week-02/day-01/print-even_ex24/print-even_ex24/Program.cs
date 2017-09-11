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
            Console.WriteLine("Even numbers between 0 and 500 using while loop:\n");

            while (counter <= 500)
            {
                Console.WriteLine(counter);
                counter = counter + 2;
            }

            Console.ReadLine();

            Console.WriteLine("Even numbers between 0 and 500 using for loop:\n");

            for (int i = 0; i <= 500; i++)
            {
                if (i%2 == 0)
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

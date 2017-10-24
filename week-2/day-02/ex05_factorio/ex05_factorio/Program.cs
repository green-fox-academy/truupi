
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write here the number for which you want to know its factorial: \n");
            int input = Int32.Parse(Console.ReadLine());
            int result = Factorial(input);
            Console.WriteLine("\nYour result:\n" + result + "\nNice!");
            Console.ReadLine();
        }

        static int Factorial(int input)
        {
               if (input <= 1)
                   return 1;
               return input * Factorial(input - 1);
        }
    }
}

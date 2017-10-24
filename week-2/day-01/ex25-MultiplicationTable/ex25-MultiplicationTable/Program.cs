using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex25_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10 + 1; i++)
            {
                int calculation = i * number;
                Console.WriteLine(i + " * " + number + " = " + (calculation));
            }
            Console.ReadLine();
        }
    }
}

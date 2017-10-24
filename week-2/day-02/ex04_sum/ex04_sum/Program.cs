using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number here: \n");
            int userInput = int.Parse(Console.ReadLine());

            int result = Sum(userInput);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Sum(int input)
        {
            
            for (int i = input-1; i >= 0; i--)
            {
                input += i;
            }
            return input;
        }

    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type here the number of CHICKENS the farmer should have:\n");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease type here the number of PIGS the farmer should have:\n");
            int userInput2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAll the animals on the farm have " + Count(userInput, userInput2) + " legs altogether.");
            Console.ReadLine();
        }

        static int Count(int input, int input2)
        {
            int input3 = (input * 2) + (input2 * 4);
            return input3;
        }
    }
}

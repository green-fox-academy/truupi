using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_two_alot_ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number: ");
            string userInput = Console.ReadLine();
            int userNum = Int32.Parse(userInput);
            
            if (userNum == 0)
            {
                Console.WriteLine("Not enough!");
            }
            else if (userNum == 1)
            {
                Console.WriteLine("One");
            }
            else if (userNum == 2)
            {
                Console.WriteLine("Two");
            }
            else if (userNum > 2)
            {
                Console.WriteLine("A lot!");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_bigger_ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers and I tell you which one is bigger: ");
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            int userNum1 = Int32.Parse(userInput1);
            int userNum2 = Int32.Parse(userInput2);

            if (userNum1 > userNum2)
            {
                Console.WriteLine(userNum1 +" is the bigger one!");
            }
            else
            {
                Console.WriteLine(userNum2 + " is the bigger one!");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let me tell you whether your number is even or odd. Enter your number: ");
            string userInput = Console.ReadLine();
            int userNum = Int32.Parse(userInput);

            if ((userNum & 1) == 0)
                Console.WriteLine("EVEN!\n");
            else
                Console.WriteLine("ODD!\n");

            Console.ReadKey();
        }
    }
}

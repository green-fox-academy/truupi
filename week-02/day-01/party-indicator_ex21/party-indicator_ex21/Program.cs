using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party_indicator_ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see how good the party was! How many girls were there? ");
            string girls = Console.ReadLine();
            Console.WriteLine("Good! Now tell me how many boys came? ");
            string boys = Console.ReadLine();

            int userNum1 = Int32.Parse(girls);
            int userNum2 = Int32.Parse(boys);

            if (userNum1 > userNum2)
            {
                Console.WriteLine(userNum1 + " is the bigger one!");
            }
            else
            {
                Console.WriteLine(userNum2 + " is the bigger one!");
            }

            Console.ReadKey();
        }
    }
}

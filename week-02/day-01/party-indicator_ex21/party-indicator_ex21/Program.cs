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

            if (userNum1 == userNum2 && (userNum1 + userNum2) > 20)
            {
                Console.WriteLine("The party is excellent!");
            }
            else if (userNum1 != userNum2 && (userNum1 + userNum2) > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (userNum1 > 0 && (userNum1 + userNum2) < 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (userNum1 == 0 && (userNum2+userNum1) > 0)
            {
                Console.WriteLine("Ouch! Sausage party?");
            }
            Console.ReadKey();
        }
    }
}

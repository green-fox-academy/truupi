using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex22_ConditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(First());
            Console.WriteLine(Second());
            Console.WriteLine(Third());
            Console.ReadLine();

           

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            Console.WriteLine(out3);
        }

        static double First()
        {
            double input = 20;
            if (input % 2 == 0)
            {
                input++;
            }
            return input;
        }
        
        static string Second()
        {
            int b = 15;
            string out2 = "{0}";
            if (b > 10 && b < 20)
            {
                out2 = "Sweet!";
            }
            else if (b < 10)
            {
                out2 = "More!";
            }
            else if (b > 20)
            {
                out2 = "Less!";
            }
            return out2;
        }

        static int Third()
        {
            int c = 123;
            int credits = 100;
            bool isBonus = false;

            if (credits >= 50 && isBonus)
            {
                c -= 2;
            }
            else if (credits < 50 && isBonus)
            {
                c--;
            }
            else if (!isBonus)
            {
                c += 0;
            }
            return c;
        }
    }
}

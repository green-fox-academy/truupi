using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            string result = Greet(al);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static string Greet(string in1)
        {
            string result = "Greetings, dear " + in1 + "!";
            return result;
        }
    }
}

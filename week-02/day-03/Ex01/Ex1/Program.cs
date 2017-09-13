using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ex());
            Console.ReadLine();
        }

        static string Ex()
        {
            string example = "In a dishwasher far far away";
            string result = example.Replace("dishwasher", "galaxy");
            return result;
        }
    }
}

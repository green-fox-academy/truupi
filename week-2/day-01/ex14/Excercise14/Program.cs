using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of km you want to convert to miles: ");
            string userInputstring = Console.ReadLine();
            double userInputdouble = Convert.ToDouble(userInputstring);
            Console.WriteLine(userInputdouble + " km = " + userInputdouble * 0.621371192 + " miles");
            Console.ReadLine();
        }
    }
}

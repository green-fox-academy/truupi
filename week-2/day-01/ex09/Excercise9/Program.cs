using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 84;
            double heightInM = 1.88;
            double bmi = massInKg / (heightInM * heightInM);

            Console.WriteLine("My BMI index is: " + bmi);
            Console.ReadLine();
        }
    }
}

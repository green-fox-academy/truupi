using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int daily = 6;
            double semester = 17;
            int workday = 5;
            double weeklyavg = 52;
            double allhours = semester * workday * daily;            


            Console.WriteLine(allhours);

            Console.WriteLine(allhours / (semester * weeklyavg) * 100 + "%");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How long the side of the cube shall be?  ");
            string userInput = Console.ReadLine();
            double num = Convert.ToDouble(userInput);

            double surface = num * (Math.Pow(6, 2));
            double volume = Math.Pow(num, 3);

            Console.WriteLine("Surface of the cub: " + surface);
            Console.WriteLine("Volume of the cub: " + volume);

            Console.ReadLine();

        }
    }
}

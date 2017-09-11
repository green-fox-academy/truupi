using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_ex28
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = "";
            Console.WriteLine("Enter here the size of your triangle:\n");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }
            Console.ReadLine();

        }
    }
}

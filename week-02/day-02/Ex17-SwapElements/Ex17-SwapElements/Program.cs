using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };
            
            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            foreach (string item in abc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

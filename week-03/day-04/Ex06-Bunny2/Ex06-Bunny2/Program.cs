using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunnyNum = 7;
            Console.WriteLine(Recursive(bunnyNum));
            Console.ReadLine();
        }

        static int Recursive(int bunnyNum)
        {
            if (bunnyNum == 0)
            {
                return 0;
            }
            if (bunnyNum % 2 == 1)
            {
                return 2 + Recursive(bunnyNum - 1);
            }
            return 3 + Recursive(bunnyNum - 1);
        }
    }
}

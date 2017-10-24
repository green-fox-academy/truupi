using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Bunny
{
    class Program
    {
        static void Main(string[] args)
        {
            int BunnyNum = 13;
            Console.WriteLine(Recursive(BunnyNum));
            Console.ReadLine();
        }

        static int Recursive(int BunnyNum)
        {
            int ears = 2;
            if (BunnyNum == 0)
            {
                return 0;
            }
            else
            {
                return ears + Recursive(BunnyNum - 1);
            }
        }
    }
}

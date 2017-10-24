using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number:" );
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power number:" );
            int powerNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:\n" + Recursive(baseNum, powerNum));
            Console.ReadLine();
        }

        static int Recursive(int baseNum, int powerNum)
        {
            if (powerNum == 0)
            {
                return 1;
            }
            else
                return baseNum * Recursive(baseNum, powerNum - 1);
        }
    }
}

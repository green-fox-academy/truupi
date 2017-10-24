using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_doubling
{
    class Program
    {
        public static int Doubling(int input1)
        {
            int result = input1 * 2;
            return result;
        }

        static void Main(string[] args)
        {
            int ak = 123;
            int result = Doubling(ak);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

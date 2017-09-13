using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_change_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 8, 5, 6 };
            s[3] = 4;
            Console.WriteLine(s[3]);
            Console.ReadLine();

        }
    }
}

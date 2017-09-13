using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_increment_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5 };
            t[2]++;
            Console.WriteLine(t[2]);
            Console.ReadLine();
        }
    }
}

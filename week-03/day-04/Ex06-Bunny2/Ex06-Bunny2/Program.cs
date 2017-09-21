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
            int[] BunnyRow = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Recursive());
            Console.ReadLine();
        }

        static int Recursive()
        {
            int[] BunnyRow = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = BunnyRow.Length;

            return n;
        }
    }
}

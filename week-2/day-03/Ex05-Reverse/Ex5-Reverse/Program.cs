using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            Console.WriteLine(Reverser(reversed));
            Console.ReadLine();
        }

        static string Reverser(string s)
        {
            char[] lol = s.ToCharArray();
            Array.Reverse(lol);
            return new string(lol);
        }
    }
}

using System;
using System.Linq;

namespace MiniEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCommonLetters("Green Fox Academy", "Gf A "));
            Console.ReadLine();
        }

        private static char[] GetCommonLetters(string inputWord1, string inputWord2)
        {
            return ((inputWord1.ToLower().Replace(" ", "").Intersect(inputWord2.ToLower().Replace(" ", ""))).ToArray());
        }
    }
}

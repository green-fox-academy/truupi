using System;
using System.Linq;

namespace MiniEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCommonLetters("Green Fox Academy", "Gf A "));
            Console.WriteLine(GetCommonLetters(null, "Gf A "));
            Console.WriteLine(GetCommonLetters("", "Gf a "));
            Console.ReadLine();
        }

        private static char[] GetCommonLetters(string inputWord1, string inputWord2)
        {
            if (inputWord1 != null && inputWord2 != null)
            {
                return ((inputWord1.ToLower().Replace(" ", "")
                    .Intersect(inputWord2.ToLower().Replace(" ", "")))
                    .ToArray());
            }
            else
            {
                return String.Empty.ToArray();
            }
        }
    }
}

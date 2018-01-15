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
            Console.WriteLine(GetCommonLettersWithoutLinq("mamai", "aimam"));
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

        private static char[] GetCommonLettersWithoutLinq(string word1, string word2)
        {
            string common = String.Empty;
            char[] commonLetters = new char[word1.Length];

            for (int i = 0; i < word1.Length; i++)
            {
                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        commonLetters[i] = word2[j];
                    }
                }
            }
            return commonLetters;
        }
    }
}

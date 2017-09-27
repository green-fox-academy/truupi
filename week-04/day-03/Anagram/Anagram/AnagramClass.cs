using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramClass
    {
        public bool IsAnagram(string word, string word2)
        {
            return StringConvert(word) == StringConvert(word2);
        }

        private string StringConvert(string word)
        {
            char[] array = word.ToArray();
            Array.Sort(array);
            return Convert.ToString(array);
        }
    }
}

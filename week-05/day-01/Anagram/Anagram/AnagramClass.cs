using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramClass
    {
        public bool AnagramCheck (string word1, string word2)
        {
            return (word1 == null || word2 == null) ? false : StringConvert(word1) == StringConvert(word2);
        }

        private string StringConvert(string word)
        {            
            char[] array = word.Replace(" ", "").ToLower().ToArray();
            Array.Sort(array);
            return new string(array);           
        }
    }

}


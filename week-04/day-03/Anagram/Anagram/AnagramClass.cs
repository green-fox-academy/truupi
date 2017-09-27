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
            bool isitanagram = true;
            char[] char1 = SortArray(ConvertString(word));
            char[] char2 = SortArray(ConvertString(word2));

            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] != char2[i])
                {
                    isitanagram = false;
                    break;
                }
            }
            return isitanagram;
        }

        private char[] ConvertString(string inputString)
        {
            char[] char1 = inputString.ToCharArray();
            return char1;
        }

        private char[] SortArray(char[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray;
        }
    }
}

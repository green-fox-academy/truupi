using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class CountClass
    {
        public Dictionary<char, int> StringToDict(string word)
        {
            Dictionary<char, int> resultDict = new Dictionary<char, int>();

            if (String.IsNullOrEmpty(word))
            {
                return resultDict;
            }
            foreach (char letter in word)
            {
                if (!resultDict.ContainsKey(letter))
                {
                    resultDict.Add(letter, 1);
                }
                else
                {
                    resultDict[letter]++;
                }
            }
            return resultDict;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;
using NUnit.Framework;

namespace AnagramTest
{
    [TestFixture]

    public class AnagramClassTest
    {
        AnagramClass anie = new AnagramClass();

        [Test]
        public void AnagramTester()
        {
            string word = "bubika";
            string word2 = "abikub";
            bool result = true;
            Assert.AreEqual(result, anie.IsAnagram(word, word2));
        }
    }
}

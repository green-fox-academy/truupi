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
        AnagramClass anagrClass = new AnagramClass();

        [Test]
        public void AnagramTester()
        {
            string word = "spoN sor";
            string word2 = "sp on  soR";
            bool result = true;
            Assert.AreEqual(result, anagrClass.AnagramCheck(word, word2));
        }
    }
}

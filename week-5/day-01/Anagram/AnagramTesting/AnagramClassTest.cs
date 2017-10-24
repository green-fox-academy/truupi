using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;
using NUnit.Framework;

namespace AnagramTesting
{
    [TestFixture]
    public class AnagramClassTest
    {
        public AnagramClass anclass = new AnagramClass(); 

        [Test]
        public void IsStringTheSame()
        {
            string word1 = "borso";
            string word2 = "borso";
            bool result = true;
            Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
            word2 = "huvelyes";
            result = false;
            Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        }

        [Test]
        public void UpperOrSmaller()
        {
            string word1 = "borso";
            string word2 = "BORSO";
            bool result = true;
            Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        }

        [Test]
        public void StingWithSpaces()
        {
            string word1 = "borso";
            string word2 = "b o  r s o";
            bool result = true;
            Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        }

        [Test]
        public void StingWithNull()
        {
            string word1 = "borso";
            string word2 = null;
            bool result = false;
            Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        }

        [Test]
        public void EmptyString()
        {
            string word1 = "borso";
            string word2 = "";
            bool result = false;
            Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        }

    }
}

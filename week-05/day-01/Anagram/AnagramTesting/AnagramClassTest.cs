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
            word2 = "osrob";
            result = true;
            Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        }

        //[Test]
        //public void AreStingsLengthTheSame()
        //{
        //    string word1 = "borso";
        //    string word2 = "kiskunfelegyhaza";
        //    bool result = false;
        //    Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        //}

        //[Test]
        //public void UpperOrSmaller()
        //{
        //    string word1 = "borso";
        //    string word2 = "BORSO";
        //    bool result = false;
        //    Assert.AreEqual(result, anclass.AnagramCheck(word1, word2));
        //}

    }
}

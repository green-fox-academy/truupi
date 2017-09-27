using CountLetters;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersTest
{
    [TestFixture]

    public class CountClassTest
    {
        CountClass testing = new CountClass();

        [Test]
        public void IsItRight()
        {
            string input = "alma";
            Dictionary<char, int> testDict = new Dictionary<char, int>()
            {
                { 'a', 2 },
                { 'l', 1 },
                { 'm', 1 }
            };
            Assert.AreEqual(testDict, testing.StringToDict(input));
        }
    }
}

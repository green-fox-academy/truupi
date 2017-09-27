using Fibonacci;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTest
{
    [TestFixture]
    public class FiboClassTest
    {
        FiboClass fibi = new FiboClass();

        [Test]
        public void TestingFiboIndex()
        {
            double input = 8;
            int output = 21;
            Assert.AreEqual(output, fibi.GetNthFibonacci(input));
        }
    }
}

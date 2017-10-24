using Apple;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleTest
{
    [TestFixture]

    public class AppleClassTest
    {
        AppleClass appleclass = new AppleClass();

        [Test]
        public void Test_Apple_ReturnsApple()
        {
            string apple = "pear";
            Assert.AreEqual(apple, appleclass.GetApple());
        }
    }
}

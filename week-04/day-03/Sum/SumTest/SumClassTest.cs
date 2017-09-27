using NUnit.Framework;
using Sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTest
{
    [TestFixture]
    public class SumClassTest
    {
        SumClass SumList = new SumClass();

        [Test]
        public void Test_EmptyListSum()
        {
            var emptyList = new List<int>();
            int output = 0;
            Assert.AreEqual(output, SumList.ListSum(emptyList));
        }

        [Test]
        public void Test_MultiListSum()
        {
            var mulList = new List<int> { 3, 4, 5, 6, 6, 7, 6, 3 };
            int result = 40;
            Assert.AreEqual(result, SumList.ListSum(mulList));
        }

        [Test]
        public void Test_SumClass2()
        {
            var oneList = new List<int> { 3 };
            int output = 3;
            Assert.AreEqual(output, SumList.ListSum(oneList));
        }

        [Test]
        public void Test_SumClass3()
        {
            int output = -1;
            Assert.AreEqual(output, SumList.ListSum(null));
        }
    }
}

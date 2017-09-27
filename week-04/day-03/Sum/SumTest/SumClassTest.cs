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
        [Test]
        public void Test_EmptyListSum()
        {
            var emptyList = new List<int>();
            SumClass SumList = new SumClass();
            int output = 0;
            Assert.AreEqual(output, SumList.ListSum(emptyList));
        }

        [Test]
        public void Test_MultiListSum()
        {
            var mulList = new List<int> { 3, 4, 5, 6, 6, 7, 6, 3 };
            SumClass SumList = new SumClass();
            int output = 40;
            Assert.AreEqual(output, SumList.ListSum(mulList));
        }

        [Test]
        public void Test_SumClass2()
        {
            var oneList = new List<int> { 3 };
            SumClass sumList = new SumClass();
            int output = 3;
            Assert.AreEqual(output, sumList.ListSum(oneList));
        }

        [Test]
        public void Test_SumClass3()
        {
            SumClass sumList = new SumClass();
            int output = -1;
            Assert.AreEqual(output, sumList.ListSum(null));
        }
    }
}

using NUnit.Framework;
using PokerFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTests
{
    [TestFixture]

    public class PokerAppTest
    {
        PokerApp pokerGame = new PokerApp();

        static void Main(string[] args)
        {
        }

        [Test]
        public void ValidCardTest()
        {
            string card ="2H";
            bool output = true;
            Assert.AreEqual(output, pokerGame.IsCardValid(card));
        }

        [Test]
        public void InvalidCardTest()
        {
            string card = "11H";
            bool output = false;
            Assert.AreEqual(output, pokerGame.IsCardValid(card));
        }

        [Test]
        public void ValidCardTestAgain()
        {
            string card = "4D";
            bool output = true;
            Assert.AreEqual(output, pokerGame.IsCardValid(card));
        }

        [Test]
        public void ValidCardTestAgainAgain()
        {
            string card = "3S";
            bool output = true;
            Assert.AreEqual(output, pokerGame.IsCardValid(card));
        }

        [Test]
        public void ValidCardLength()
        {
            string card = "3DS";
            bool output = false;
            Assert.AreEqual(output, pokerGame.IsCardValid(card));
        }

        [Test]
        public void FiveCardTest()
        {
            string cards = "3S XX XX 7D AD";
            bool output = false;
            Assert.AreEqual(output, pokerGame.CheckHand(cards));
        }

        [Test]
        public void SameFiveCardTest()
        {
            string cards = "3S 3S 3S 3S 3S";
            bool output = false;
            Assert.AreEqual(output, pokerGame.CheckHand(cards));
        }
    }
}

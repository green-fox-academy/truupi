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
            string card = "4DC";
            bool output = false;
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
        public void FiveCardTestFalse()
        {
            string cards = "3S XX XX 7D AD";
            bool output = false;
            Assert.AreEqual(output, pokerGame.CheckHand(cards));
        }

        [Test]
        public void FiveCardTestTrue()
        {
            string cards = "3S 4D 5D 7D AD";
            bool output = true;
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

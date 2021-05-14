using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BowlingGame.Models;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameUnitTests
    {
        private Game g;
        protected void Setup()
        {
            g = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
        }

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        private void RollStrike()
        {
            g.Roll(10);
        }

        [TestMethod]
        public void TestGutterGame()
        {
            Setup();
            RollMany(20, 0);
            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            Setup();
            for (int i = 0; i < 20; i++)
                g.Roll(1);
            Assert.AreEqual(20, g.Score());
        }
        [TestMethod]
        public void TestOneSpare()
        {
            Setup();
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            Setup();
            RollStrike(); // strike
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, g.Score());
        }

    }
}

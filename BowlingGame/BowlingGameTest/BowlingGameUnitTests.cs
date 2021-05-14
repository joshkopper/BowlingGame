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
    }
}

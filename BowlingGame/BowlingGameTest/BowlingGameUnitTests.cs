using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BowlingGame.Models;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameUnitTests
    {
        [TestMethod]
        public void TestGutterGame()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
                g.Roll(0);
            Assert.AreEqual(0, g.Score());
        }
    }
}

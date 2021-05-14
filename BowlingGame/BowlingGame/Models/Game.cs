using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    public class Game
    {
        private int CurrentScore = 0;
        public void Roll(int pins)
        {
            CurrentScore += pins;
        }
        public int Score()
        {
            return CurrentScore;
        }

    }
}

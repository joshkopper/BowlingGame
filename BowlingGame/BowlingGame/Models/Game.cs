using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    public class Game
    {
        private int[] Rolls = new int[21];
        private int CurrentRoll = 0;
        private int CurrentScore = 0;

        public void Roll(int pins)
        {
            CurrentScore += pins;
            Rolls[CurrentRoll++] = pins;

        }
        public int Score()
        {
            int CurrentScore = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSpare(frameIndex)) // spare
                {
                    CurrentScore += 10 + Rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    CurrentScore += Rolls[frameIndex] + Rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return CurrentScore;
        }

        private bool IsSpare(int frameIndex)
        {
            return Rolls[frameIndex] +
                   Rolls[frameIndex + 1] == 10;
        }


    }
}

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
                if (IsStrike(frameIndex)) // strike
                {
                    CurrentScore += 10 +
                            StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex)) // spare
                {
                    CurrentScore += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    CurrentScore += SumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return CurrentScore;
        }
        private int SumOfBallsInFrame(int frameIndex)
        {
            return Rolls[frameIndex] + Rolls[frameIndex + 1];
        }

        private int SpareBonus(int frameIndex)
        {
            return Rolls[frameIndex + 2];
        }

        private int StrikeBonus(int frameIndex)
        {
            return Rolls[frameIndex + 1] + Rolls[frameIndex + 2];
        }

        private bool IsSpare(int frameIndex)
        {
            return Rolls[frameIndex] +
                   Rolls[frameIndex + 1] == 10;
        }
        private bool IsStrike(int frameIndex)
        {
            return Rolls[frameIndex] == 10;
        }

    }
}

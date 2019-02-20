using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameXP
{
    public class BowlingGame
    {
        private Bowls bowls = new Bowls();

        public void Bowl(int pins)
        {
            bowls.AddBowl(pins);
        }

        public int FinalScore()
        {
            int totalScore = 0;

            Frames frames = bowls.GetFrames();

            for (int i = 0; i < 10; i++)
            {
                totalScore += frames.GetFrame(i).Bowl(0).ToInt();
                totalScore += frames.GetFrame(i).Bowl(1).ToInt();
            }

            return totalScore;
        }
    }
}

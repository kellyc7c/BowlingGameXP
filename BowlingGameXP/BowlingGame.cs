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

            foreach (Frame frame in frames)
            {
                totalScore += frame.GetIntermediateScore();
            }

            return totalScore;
        }
    }
}

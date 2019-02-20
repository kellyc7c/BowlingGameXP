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
            BowlScore totalScore = new BowlScore(0);

            Frames frames = bowls.GetFrames();

            foreach (Frame frame in frames)
            {
                totalScore = totalScore.Add(frame.GetIntermediateScore());
            }

            return totalScore.ToInt();
        }
    }
}

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

            for (int i = 0; i < frames.Count(); i++)
            {
                if (frames[i].IsSpare())
                {
                    totalScore = frames[i+1].AddSpareBonus(totalScore);
                }
                totalScore = totalScore.Add(frames[i].GetIntermediateScore());
            }

            return totalScore.ToInt();
        }
    }
}

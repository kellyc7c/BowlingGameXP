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
                totalScore = CalculateSpare(totalScore, frames, i);
                totalScore = CalculateStrike(totalScore, frames, i);

                totalScore = totalScore.Add(frames[i].GetIntermediateScore());
            }

            return totalScore.ToInt();
        }

        private static BowlScore CalculateStrike(BowlScore totalScore, Frames frames, int i)
        {
            if (frames[i].IsStrike() && i < frames.Count() - 1)
            {
                totalScore = CalculateStrikeBonusIfNotPenultimateFrame(totalScore, frames, i);
                totalScore = totalScore.Add(frames[i + 1].StrikeBonus());
            }

            return totalScore;
        }

        private static BowlScore CalculateStrikeBonusIfNotPenultimateFrame(BowlScore totalScore, Frames frames, int i)
        {
            if (i < frames.Count() - 2 && frames[i + 1].IsStrike())
            {
                totalScore = frames[i + 2].AddSpareBonus(totalScore);
            }

            return totalScore;
        }

        private static BowlScore CalculateSpare(BowlScore totalScore, Frames frames, int i)
        {
            if (frames[i].IsSpare() && i < frames.Count() - 1)
            {
                totalScore = frames[i + 1].AddSpareBonus(totalScore);
            }

            return totalScore;
        }
    }
}

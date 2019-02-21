﻿using System.Collections.Generic;

namespace BowlingGameXP
{
    class Frame
    {
        List<BowlScore> bowls = new List<BowlScore>();

        public Frame(BowlScore bowl)
        {
            bowls.Add(bowl);
        }

        public Frame(BowlScore firstBowl, BowlScore secondBowl)
        {
            bowls.Add(firstBowl);
            bowls.Add(secondBowl);
        }

        public Frame(BowlScore firstBowl, BowlScore secondBowl, BowlScore thirdBowl)
        {
            bowls.Add(firstBowl);
            bowls.Add(secondBowl);
            bowls.Add(thirdBowl);
        }

        public int NumberOfBowls()
        {
            return bowls.Count;
        }

        public BowlScore GetIntermediateScore()
        {
            BowlScore totalScore = new BowlScore(0);

            if (bowls.Count == 3)
            {
                totalScore = totalScore.Add(CalculateFinalFrameBonus());
            }

            

            foreach (BowlScore bowl in bowls)
            {
                totalScore = totalScore.Add(bowl);
            }

            return totalScore;
        }

        private BowlScore CalculateFinalFrameBonus()
        {
            if (IsSpare())
            {
                return bowls[2];
            }

            return new BowlScore(0);
        }

        public bool IsSpare()
        {
            if (bowls.Count > 1 && bowls[0].Add(bowls[1]).Equals(new BowlScore(10)))
            {
                return true;
            }

            return false;
        }

        public bool IsStrike()
        {
            if (bowls[0].Equals(new BowlScore(10)))
            {
                return true;
            }

            return false;
        }

        public BowlScore AddSpareBonus(BowlScore currentScore)
        {
            return currentScore.Add(bowls[0]);
        }
    }
}

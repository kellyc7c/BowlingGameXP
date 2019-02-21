using System.Collections.Generic;

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

            foreach (BowlScore bowl in bowls)
            {
                totalScore = totalScore.Add(bowl);
            }

            return totalScore;
        }

        public bool IsSpare()
        {
            if (bowls.Count > 1 && bowls[0].Add(bowls[1]).Equals(new BowlScore(10)))
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

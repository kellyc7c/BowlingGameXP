using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameXP
{
    class Frames : IEnumerable<Frame>
    {
        List<Frame> frames = new List<Frame>();

        public void AddFrame(Frame frame)
        {
            frames.Add(frame);
        }

        public IEnumerator<Frame> GetEnumerator()
        {
            foreach (Frame frame in frames)
            {
                yield return frame;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

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
    }
}

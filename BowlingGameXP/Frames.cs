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

        public Frame GetFrame(int index)
        {
            return frames[index];
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
        List<Bowl> bowls = new List<Bowl>();

        public Frame(Bowl bowl)
        {
            bowls.Add(bowl);
        }

        public Frame(Bowl firstBowl, Bowl secondBowl)
        {
            bowls.Add(firstBowl);
            bowls.Add(secondBowl);
        }

        public Frame(Bowl firstBowl, Bowl secondBowl, Bowl thirdBowl)
        {
            bowls.Add(firstBowl);
            bowls.Add(secondBowl);
            bowls.Add(thirdBowl);
        }

        public int NumberOfBowls()
        {
            return bowls.Count;
        }

        public int GetIntermediateScore()
        {
            int total = 0;

            foreach (Bowl bowl in bowls)
            {
                total += bowl.ToInt();
            }

            return total;
        }
    }
}

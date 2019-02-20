using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameXP
{
    class Bowls
    {
        List<BowlScore> bowls = new List<BowlScore>();

        public void AddBowl(int pins)
        {
            bowls.Add(new BowlScore(pins));
        }

        public Frames GetFrames()
        {
            Frames frames = new Frames();

            int bowlsIndex = 0;

            for (int frameCount = 0; frameCount < 9; frameCount++, bowlsIndex += 2)
            {
                frames.AddFrame(new Frame(bowls[bowlsIndex], bowls[bowlsIndex + 1]));
            }

            if (bowls.Count - bowlsIndex == 2)
            {
                frames.AddFrame(new Frame(bowls[bowlsIndex], bowls[bowlsIndex + 1]));
                return frames;
            }

            frames.AddFrame(new Frame(bowls[bowlsIndex], bowls[bowlsIndex + 1], bowls[bowlsIndex + 3]));
            return frames;


        }
    }

    class BowlScore
    {
        private int pins;

        public BowlScore(int pins)
        {
            this.pins = pins;
        }

        public bool Equals(BowlScore bowl)
        {
            if (this.pins == bowl.pins)
            {
                return true;
            }

            return false;
        }

        public BowlScore Add(BowlScore score)
        {
            return new BowlScore(score.pins + this.pins);
        }

        public int ToInt()
        {
            return pins;
        }
    }
}

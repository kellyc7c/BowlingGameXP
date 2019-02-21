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

            for (int frameCount = 0; frameCount < 9; frameCount++)
            {
                if (bowls[bowlsIndex].Equals(new BowlScore(10)))
                {
                    frames.AddFrame(new Frame(bowls[bowlsIndex]));
                    bowlsIndex += 1;
                    continue;
                }
                frames.AddFrame(new Frame(bowls[bowlsIndex], bowls[bowlsIndex + 1]));
                bowlsIndex += 2;
            }

            if (bowls.Count - bowlsIndex == 2)
            {
                frames.AddFrame(new Frame(bowls[bowlsIndex], bowls[bowlsIndex + 1]));
                return frames;
            }

            frames.AddFrame(new Frame(bowls[bowlsIndex], bowls[bowlsIndex + 1], bowls[bowlsIndex + 2]));
            return frames;
        }
    }
}

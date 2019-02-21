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

        public Frame this[int index]
        {
            get { return frames[index]; }
        }

        public int Count()
        {
            return frames.Count;
        }

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
}

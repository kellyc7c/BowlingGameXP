using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameXP
{
    public class BowlingGame
    {
        int pins = 0;

        public void Bowl(int pins)
        {
            this.pins += pins;
        }

        public int FinalScore()
        {
            return pins;
        }
    }
}

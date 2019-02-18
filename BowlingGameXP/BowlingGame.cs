using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameXP
{
    public class BowlingGame
    {
        private int[] bowls = new int[21];
        private int bowlCount = 0;

        public void Bowl(int pins)
        {
            bowls[bowlCount] = pins;
            bowlCount++;
        }

        public int FinalScore()
        {
            int totalScore = 0;
            foreach (int bowlScore in bowls)
            {
                totalScore += bowlScore;
            }

            return totalScore;
        }
    }
}

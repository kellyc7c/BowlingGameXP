using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingGameXP.Tests
{
    [TestFixture]
    public class BowlingGameTests
    {
        [Test]
        public void BowlingZeroEveryTimeShouldReturnFinalScoreOfZero()
        {
            BowlingGame bowlingGame = new BowlingGame();

            for (int i = 0; i < 20; i++)
            {
                bowlingGame.Bowl(0);
            }

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(0));
        }

        [Test]
        public void BowlingOneEveryTimeShouldReturnScoreOf20()
        {
            BowlingGame bowlingGame = new BowlingGame();

            for (int i = 0; i < 20; i++)
            {
                bowlingGame.Bowl(1);
            }

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(1));
        }

    }
}

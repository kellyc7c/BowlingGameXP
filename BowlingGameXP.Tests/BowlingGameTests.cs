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
        BowlingGame bowlingGame = new BowlingGame();

        [SetUp]
        public void SetUp()
        {
            BowlingGame bowlingGame = new BowlingGame();
        }

        [Test]
        public void BowlingZeroEveryTimeShouldReturnFinalScoreOfZero()
        {
            runGame(20, 0);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(0));
        }

        [Test]
        public void BowlingOneEveryTimeShouldReturnScoreOf20()
        {
            runGame(20, 1);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(1));
        }

        private void runGame(int bowls, int pins)
        {
            for (int i = 0; i < bowls; i++)
            {
                bowlingGame.Bowl(pins);
            }
        }

    }
}

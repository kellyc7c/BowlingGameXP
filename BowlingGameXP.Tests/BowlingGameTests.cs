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
        BowlingGame bowlingGame;

        [SetUp]
        public void SetUp()
        {
            bowlingGame = new BowlingGame();
        }

        [Test]
        public void BowlingZeroEveryTimeShouldReturnFinalScoreOfZero()
        {
            RunGame(20, 0);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(0));
        }

        [Test]
        public void BowlingOneEveryTimeShouldReturnScoreOfTwenty()
        {
            RunGame(20, 1);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(20));
        }

        [Test]
        public void SpareFollowedByANumberOfPinsShouldReturnCorrectScore()
        {
            bowlingGame.Bowl(3);
            bowlingGame.Bowl(7);
            bowlingGame.Bowl(6);

            RunGame(17, 0);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(22));
        }

        [Test]
        public void SpareInFinalFrameShouldReturnCorrectScore()
        {
            RunGame(18, 0);

            bowlingGame.Bowl(6);
            bowlingGame.Bowl(4);
            bowlingGame.Bowl(5);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(15));
        }

        [Test]
        public void StrikeFollowedByTwoRollsShouldReturnCorrectScore()
        {
            bowlingGame.Bowl(10);
            bowlingGame.Bowl(10);
            bowlingGame.Bowl(6);
            bowlingGame.Bowl(2);

            RunGame(16, 0);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(52));
        }

        [Test]
        public void StrikesInvolvingFinalFrameShouldReturnCorrectScore()
        {
            RunGame(16, 0);

            bowlingGame.Bowl(10);
            bowlingGame.Bowl(10);
            bowlingGame.Bowl(6);
            bowlingGame.Bowl(2);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(44));
        }

        [Test]
        public void PerfectGameReturnsCorrectScore()
        {
            RunGame(12, 10);

            Assert.That(bowlingGame.FinalScore(), Is.EqualTo(300));
        }

        private void RunGame(int bowls, int pins)
        {
            for (int i = 0; i < bowls; i++)
            {
                bowlingGame.Bowl(pins);
            }
        }

    }
}

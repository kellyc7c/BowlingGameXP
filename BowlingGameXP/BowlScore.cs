namespace BowlingGameXP
{
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

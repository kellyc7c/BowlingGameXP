using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameXP
{
    class Bowls
    {
        List<Bowl> bowls = new List<Bowl>();

        public void AddBowl(int pins)
        {
            bowls.Add(new Bowl(pins));
        }

        public List<Bowl> GetBowls()
        {
            return bowls;
        }
    }

    class Bowl
    {
        int pins;

        public Bowl(int pins)
        {
            this.pins = pins;
        }

        public bool Equals(Bowl bowl)
        {
            if (this.pins == bowl.pins)
            {
                return true;
            }

            return false;
        }

        public int ToInt()
        {
            return pins;
        }
    }
}

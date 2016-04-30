using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {

        public static int GetScore(List<int> pins)
        {
            int score = 0;
            for (int i = 0; i < pins.Count; i+=2 )
            {
                // strike
                if (pins[i] == 10)  
                    score = pins[i] + pins[i + 2] + pins[i + 3];
                // spare
                else if (i < pins.Count-1 && pins[i] + pins[i+1] == 10 )
                    score += pins[i] + pins[i+1] + pins[i + 2];
                // the others
                else
                    score += pins[i] + pins[i+1];
            }

            return score;
        }
    }
}


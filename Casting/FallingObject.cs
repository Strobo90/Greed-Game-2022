using System;

namespace cse210_04.Game.Casting;
    
    public class FallingObject : Actor {
        private int multiplier;
        private int score;
        
       

        //
        public void setPointValue(int pointValue)
        {
            score = pointValue;
        }
        public void setMultiplier(int Multiplier)
        {
            multiplier = Multiplier;
        }
        public int getPointValue()
        {
            return score;
        }
        public int getMultiplier()
        {
            return multiplier;
        }
    }
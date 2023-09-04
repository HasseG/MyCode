using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateDecider
{
    public class DiceRoll
    {
        public int diceSides { get; set; }

        public DiceRoll(int diceSides) 
        {
            this.diceSides = diceSides;
        }

        public int RollDice()
        {
            Random rnd = new Random(diceSides);
            int roll = rnd.Next(diceSides + 1);
            
            return roll;
        }
    }
}


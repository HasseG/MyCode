using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double BonusProvider(double amount);
    public class Bonuses
    {
        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            if (amount > 5)
                return 2.0;
            else
                return 0.0;

        }
        
        public static double TenPercent(double amount)
        {
            amount = amount / 100 * 10;
            return amount;
        }
    }
}

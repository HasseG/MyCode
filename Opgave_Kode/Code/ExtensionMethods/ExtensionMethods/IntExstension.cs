using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntExstension
    {
        public static bool IsNumberDividedWhole(this double i, double a)
        {
            double result = i % a;

            if (result == 0)
            {
                return true;
            }
            else
                return false;


        }


    }
}

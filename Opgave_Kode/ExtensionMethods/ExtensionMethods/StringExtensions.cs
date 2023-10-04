using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {

        public static string Shift(this string s, int shift)
        {
            if (s == null)
            {
                return string.Empty;
            }
            int lenght = s.Length;
            int shiftAmount = shift % lenght;

            if (shiftAmount < 0)
            {
                shiftAmount += lenght;
            }
            shiftAmount = lenght - shiftAmount;
            return s.Substring(shiftAmount) + s.Substring(0, shiftAmount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static int Age(this DateTime dt)
        {
            return DateTime.Now.Year - dt.Year;
        }
        public static int Age(this DateTime dt, DateTime referenceDate)
        {
            if (referenceDate.Year - dt.Year < 0)
            {
                return 0;
            }
            else if ((referenceDate - dt).Days < 366) 
            {
                return 0;
            }
            else 
                return referenceDate.Year - dt.Year;
        }


    }
}

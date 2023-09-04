using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModelPersistence.Models
{
    public class Substitute
    {
        public int SubID { get; }
        public DateOnly Date { get; set; }
        public double Hours { get; set; }

        public Substitute(DateOnly date, double hours)
        {
            Date = date;
            Hours = hours;
        }
    }
}

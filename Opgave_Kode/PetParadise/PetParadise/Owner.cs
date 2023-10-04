using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace PetParadise
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return OwnerId + ": " + FirstName + " " + LastName + " - T: " + Phone + " - M: " + Email;
        }
        public Owner(int id)
        {
            this.OwnerId = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemid)
        {
            Amulet reAmulet = null;
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemid)
                    reAmulet = amulet;
            }
            return reAmulet;
        }
        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double totalValue = 0;

            foreach (Amulet amulet in amulets)
            {
                totalValue = totalValue + amulet.GetValue();
            }
            return totalValue;
        }



    }
}

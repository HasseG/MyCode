using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise reMerch = null;

            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                    reMerch = merchandise;
            }
            return reMerch;
        }

        public double GetTotalValue()
        {
            double total = 0;

            foreach (Merchandise merchandise in merchandises)
            {
                total = total + merchandise.GetValue();
            }
            return total;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {

            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            IValuable reValuable = null;
           
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise m)
                {
                    if(m.ItemId == id)
                        reValuable = valuable;
                }
                else if (valuable is Course c)
                {
                    if (c.Name == id)
                    {
                        reValuable = valuable;
                    }
                }
                    
            }
            return reValuable;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (IValuable valuables in valuables)
            {
                total = total + valuables.GetValue();
            }
            return total;
        }

        public int Count()
        {
            return valuables.Count();
        }


    }
}

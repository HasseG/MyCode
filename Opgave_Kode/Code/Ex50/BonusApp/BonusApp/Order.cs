using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
		private List<Product> products = new List<Product>();
		private BonusProvider _bonus;

		public BonusProvider Bonus
		{
			get { return _bonus; }
			set { _bonus = value; }
		}

		public void AddProduct(Product p)
		{
			products.Add(p);
		}
		public double GetValueOfProducts()
		{
			double sum = 0;
			foreach (Product p in products)
			{
				sum = sum + p.Value;
			}
			return sum;
		}


		public double GetBonus()
		{
			double amount = GetValueOfProducts();
			return Bonus(amount);
        }

		public double GetTotalPrice()
		{
			double getTotalVal = GetValueOfProducts();
			return getTotalVal - Bonus(getTotalVal);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuctionHouseServer
{
	public class Item
	{
		public Item(int id, string name, decimal minPrice, TimeOnly auctionStartTime, TimeOnly auctionEndTime)
		{
			Id = id;
			Name = name;
			MinPirce = minPrice;
			AuctionEndTime = auctionEndTime;
			AuctionStartTime = auctionStartTime;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public decimal MinPirce { get; set; }
		public decimal SalePrice { get; set; }
		public double AuctionLenghtInSeconds { get; set; }
		public TimeOnly AuctionStartTime { get; set; }
		public TimeOnly AuctionEndTime { get; set; }
		public bool Sold { get; set; }
		public override string ToString()
		{
			return $"{Name}, {Sold}, {MinPirce}";
		}
	}

}

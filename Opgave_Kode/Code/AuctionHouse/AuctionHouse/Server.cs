


using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AuctionHouseServer
{
	public class Server
	{
		private readonly List<Item> items;

		public Server()
		{
			items = new List<Item>();
		}
		public string ExecuteServer()
		{
			IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
			IPAddress ipAddress = ipHost.AddressList[0];
			IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11111);

			Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			string messageFromClient = "";
			try
			{

				listener.Bind(localEndPoint);

				listener.Listen(10);
				bool running = true;
				do
				{

					Console.WriteLine("Waiting connection ... ");

					Socket clientSocket = listener.Accept();

					// Data buffer
					byte[] bytes = new Byte[1024];
					string data = null;
					bool reading = true;
					do
					{

						int numByte = clientSocket.Receive(bytes);

						data += Encoding.ASCII.GetString(bytes,
												   0, numByte);

						if(data.IndexOf("<EOF>") > -1)
						{
							reading = false;
						}
					}
					while (reading);
					messageFromClient = data;

					Console.WriteLine("Text received -> {0} ", data);
					byte[] message = Encoding.ASCII.GetBytes("Message recived");

					clientSocket.Send(message);

					clientSocket.Shutdown(SocketShutdown.Both);
					clientSocket.Close();
					running = false;

				} while (running);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			return messageFromClient;
		}

		public void CreateItem(int id, string name, decimal minPrice, TimeOnly auctionStartTime, TimeOnly auctionEndTime)
		{
			Item acutionItem = new Item(id, name, minPrice, auctionStartTime, auctionEndTime);
			items.Add(acutionItem);
			Console.WriteLine($"Item created with name: {name}");
		}

		public List<Item> GetItems()
		{
			return items;
		}

		public Item GetItem(int id)
		{

			Item foundItem = items.Find(x => x.Id == id);
			return foundItem;
		}
		public void BidOnItem(decimal bidPrice, int id)
		{
			Item foundItem = GetItem(id);

			if(foundItem.SalePrice < bidPrice)
			{
				foundItem.SalePrice = bidPrice;
			}
		}

		public List<Item> GetSoldItems()
		{
			List<Item> soldItems = new List<Item>();

			foreach(Item item in items)
			{
				if(item.Sold == true)
				{
					soldItems.Add(item);
				}
			}
			return soldItems;
		}



	}
}

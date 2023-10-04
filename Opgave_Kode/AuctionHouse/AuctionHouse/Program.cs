namespace AuctionHouseServer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Server server = new Server();
			server.CreateItem(1, "Jordan 4s", 400.00, 02, );

			string clientMessage = server.ExecuteServer();
			string input = Console.ReadLine();
			switch (Convert.ToInt32(input))
			{
				case 1:
					server.CreateItem();
					break;
			}
			Console.ReadKey();
		}

	}
}
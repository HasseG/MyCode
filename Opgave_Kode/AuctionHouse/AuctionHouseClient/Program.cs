using System.Net.Sockets;
using System.Net;
using System.Text;

namespace AuctionHouseClient
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Write message to sendt to server: ");
			string input = Console.ReadLine();
			Client.ExecuteClient(input);
			Console.ReadKey();
		}
	}
}
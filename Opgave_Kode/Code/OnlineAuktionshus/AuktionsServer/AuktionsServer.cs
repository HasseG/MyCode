namespace AuktionsServer
{
	using System.Net.Sockets;
	using System.Net;
	using System.Text;
	using System.Threading;

	public class AuktionsServer
	{
		private const int port = 30000;
		private bool Running { get; set; } = true;
		private object _running = new object();
		private bool NewClientIsFound = false;
		private List<Socket> sockets = new List<Socket>();

		static void Main(string[] args)
		{
			AuktionsServer program = new AuktionsServer();
			program.Run();
		}

		private void Run()
		{
			Socket listener;

			Console.WriteLine("Starting server...");
			IPAddress ipa = Tools.GetIPAddress();
			try
			{
				listener = new Socket(ipa.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				IPEndPoint localEndPoint = new IPEndPoint(ipa, port);
				listener.Bind(localEndPoint);
				listener.Listen();

				Thread listenForClientsThread = new Thread(() => ListenForClients(listener));
				listenForClientsThread.Start();
				GetClient(listener);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}


		private void ListenForClients(Socket listener)
		{
			do
			{
				Console.Write($"Listening for connection on {listener.LocalEndPoint} ... ");
				Socket clientSocket = listener.Accept();
				Console.WriteLine($"\nCaught one at {clientSocket.LocalEndPoint}...\n");
				sockets.Add(clientSocket);
				NewClientIsFound = true;
			} while (Running);
		}


		private void GetClient(Socket listener)
		{
			try
			{
				while (Running)
				{
					if (NewClientIsFound)
					{
						Socket clientSocket = sockets.Last();
						Thread thread = new Thread(() =>
							{
								Tools.State endState = HandleClient(clientSocket);
								switch (endState)
								{
									case Tools.State.CLOSESERVER:
										lock (_running)
										{
											Running = false;
										}
										foreach (Socket clientSocket in sockets)
										{
											clientSocket.Send(Encoding.ASCII.GetBytes("The server is closing!"));
										}
										break;

									case Tools.State.EXIT:
										Console.WriteLine("Done handling client\n");
										break;
								}

								clientSocket.Shutdown(SocketShutdown.Both);
								clientSocket.Close();
							});
						thread.Start();
						NewClientIsFound = false;
					}
				}
				listener.Shutdown(SocketShutdown.Both);
				listener.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Server was shut down!");
				Console.WriteLine(e.ToString());
			}
		}

		private Tools.State HandleClient(Socket client)
		{
			byte[] bytes = new Byte[1024];
			int highestBid = 0;
			string data;
			Tools.State state = Tools.State.RUNNING;

			do
			{
				try
				{
					int numByte = client.Receive(bytes);

					data = Encoding.ASCII.GetString(bytes, 0, numByte);
					data = data.ToUpper();

					if (!ValidDataSyntax(data))
					{
						client.Send(Encoding.ASCII.GetBytes("Wrong syntax"));
					}
					else
					{
						char messageType = data[0];
						string argument = data.Substring(2);
						argument = argument.Remove(argument.Length - 1);

						switch (messageType)
						{
							case 'B':
								highestBid = Bid(client, argument, highestBid);
								break;

							case 'C':
								switch (argument)
								{
									case "EXIT":
										state = Tools.State.EXIT;
										client.Send(Encoding.ASCII.GetBytes("Bye"));
										break;

									case "CLOSESERVER":
										state = Tools.State.CLOSESERVER;
										client.Send(Encoding.ASCII.GetBytes("Closing server"));
										break;
								}
								break;
						}
					}
				}
				catch (Exception)
				{
					Console.WriteLine("Problems reading client - disconnecting");
					state = Tools.State.EXIT;
				}
			} while (state == Tools.State.RUNNING);

			return state;
		}

		private static int Bid(Socket client, string argument, int highestBid)
		{
			int result = highestBid;

			if (int.TryParse(argument, out var bid))
			{
				if (bid > highestBid)
				{
					result = bid;
					client.Send(Encoding.ASCII.GetBytes("OK"));
				}
				else
				{
					client.Send(Encoding.ASCII.GetBytes("Bid is too low"));
				}
			}
			else
			{
				client.Send(Encoding.ASCII.GetBytes("Bid is not integer"));
			}
			return result;
		}

		private bool ValidDataSyntax(string data)
		{
			//Valid data: X@Y#
			//		X (a char) is type of message , Y is message itself, @ and # are delimiters
			bool ok =
				 (data.Length >= 4) &&
				((data[0] == 'B') || (data[0] == 'C')) &&
				 //B : bid (then the message holds the amount)
				 //C : Command (message then tells to exit client or to close server - more to come...)
				 //more to come...
				 (data[1] == '@') &&
				 (data[data.Length - 1] == '#');

			return ok;
		}
	}
}

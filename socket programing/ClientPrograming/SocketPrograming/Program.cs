// A C# Program for Server 
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{

	class ServerProgram
	{

		
		static void Main(string[] args)
		{
			ExecuteServer();
		}

		public static void ExecuteServer()
		{
			//creating instance of IPHostEntry
			IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
			IPAddress ipAddr = ipHost.AddressList[0];//getting ip address
			IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);
			//forms a connection

			//creating socket
			Socket listener = new Socket(ipAddr.AddressFamily,
						SocketType.Stream, ProtocolType.Tcp);

			try
			{

				listener.Bind(localEndPoint);
				//bind method listen the listen()method at the end point.
			
				listener.Listen(10);//listen the state.

				while (true)
				{

					Console.WriteLine("Waiting connection ... ");

					//creating method for accept the listener information.
					Socket clientSocket = listener.Accept();

				
					byte[] bytes = new Byte[1024];

					string data = null;

					while (true)
					{
						//received data
						int numByte = clientSocket.Receive(bytes);

						data += Encoding.ASCII.GetString(bytes,
												0, numByte);

						if (data.IndexOf("<EOF>") > -1)
							break;
					}

					Console.WriteLine("Text received -> {0} ", data);
					byte[] message = Encoding.ASCII.GetBytes("Test Server");

					//send message to the server
					clientSocket.Send(message);

					//receiver closed
					//method is closed
					clientSocket.Shutdown(SocketShutdown.Both);
					clientSocket.Close();
				}
			}

			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}
	}
}

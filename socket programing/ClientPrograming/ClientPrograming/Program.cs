// A C# program for Client 
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{

	class ClientProgram
	{

		
		static void Main(string[] args)
		{
			ExecuteClient();
		}

	
		static void ExecuteClient()
		{

			try
			{

				
				IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());//creating instance of hostentry
				IPAddress ipAddr = ipHost.AddressList[0];//getting the ip address
				IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);//forms a connection point to a service.

				//creating socket.
				Socket sender = new Socket(ipAddr.AddressFamily,
						SocketType.Stream, ProtocolType.Tcp);

				try
				{

					//connecting to the socket
					sender.Connect(localEndPoint);

					
					Console.WriteLine("Socket connected to -> {0} ",
								sender.RemoteEndPoint.ToString());

					// sending information to the server.
					byte[] messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>");
					int byteSent = sender.Send(messageSent);

					
					byte[] messageReceived = new byte[1024];

					//receive data
					int byteRecv = sender.Receive(messageReceived);
					//printing recieved data
					Console.WriteLine("Message from Server -> {0}",
						Encoding.ASCII.GetString(messageReceived,
													0, byteRecv));

					// close connection
					sender.Shutdown(SocketShutdown.Both);
					//method close.
					sender.Close();
				}

				
				catch (ArgumentNullException ane)
				{

					Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
				}

				catch (SocketException se)
				{

					Console.WriteLine("SocketException : {0}", se.ToString());
				}

				catch (Exception e)
				{
					Console.WriteLine("Unexpected exception : {0}", e.ToString());
				}
			}

			catch (Exception e)
			{

				Console.WriteLine(e.ToString());
			}
		}
	}
}

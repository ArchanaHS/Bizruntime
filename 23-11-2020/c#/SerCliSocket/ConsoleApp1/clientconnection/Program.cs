
          
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketProgramming2
{
    class ClientSocket
    {
        static Socket sck;
        public void ClientMethod()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//connection

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            try
            {
                sck.Connect(localEndPoint);

            }
            catch
            {
                Console.WriteLine("enable to connect remote end point!..");

            }
            Console.WriteLine("enter text..");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);
            sck.Send(data);
            Console.WriteLine("Data sent!..");
            Console.WriteLine("press any key to continue..");
            Console.Read();
            sck.Close();
        }
        public static void Main(string[] args)
        {
            ClientSocket cs = new ClientSocket();
            cs.ClientMethod();


        }
    }
}

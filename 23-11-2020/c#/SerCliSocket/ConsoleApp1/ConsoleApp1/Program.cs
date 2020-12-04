using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketProgramming2
{

    class SocketProgram
    {
        static Byte[] Buffer { get; set; }
        static Socket sck;
        public static void ServerMethod()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 1234));
            sck.Listen(100);

            Socket Accepted = sck.Accept();
            Buffer = new byte[Accepted.SendBufferSize];
            int bytesRead = Accepted.Receive(Buffer);
            //new formate to hold the byte data.
            byte[] formatted = new byte[bytesRead];

            for (int i = 0; i < bytesRead; i++)
            {
                formatted[i] = Buffer[i];
            }
            string strData = Encoding.ASCII.GetString(formatted);
            Console.Write(strData + "\r\n");
            Console.Read();
            sck.Close();
            Accepted.Close();
        }

        static void Main(string[] args)
        {



            ServerMethod();
        }
    }
}

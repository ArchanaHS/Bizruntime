using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace SocketPrograming1
{
    class SocketProgram
    {
        //creating method for connecting server
        private static Socket ConnectSocket(String server, int port)
        {
            
                Socket s = null;
                IPHostEntry hostentry = null;

                // get host related information.
                hostentry = Dns.GetHostEntry(server);

                foreach (IPAddress Address in hostentry.AddressList)
                {
                    //network endpoint.
                    IPEndPoint ipe = new IPEndPoint(Address, port);
                    //creating an socket object with addressfamily,socketType, protocalType.
                    Socket tempSocket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    //socket instance conncting to the Endpoint.
                    tempSocket.Connect(ipe);
                    if (tempSocket.Connected)
                    {
                        s = tempSocket;//null
                        break;
                    }
                    else
                        continue;
                }
               

           
            return s;
          
        }
         
            

         //creating method for Communication over an sever.(sending and reciving data)
        
        private static string  SocketSendRecive(string server,int port)
        {
            //requesting data from server.
            string request = "GET / HTTP/1.1\r\nHost: " + server +
            "\r\nConnection: Close\r\n\r\n";

            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            Byte[] bytesReceived = new Byte[256];

            string page = "";

            //creating socket connection with specific server and port.
             using(Socket s= ConnectSocket(server,port))
            {
                if (s == null)
                    return ("connection failed..");
                //send request to the server.
                s.Send(bytesSent, bytesSent.Length, 0);

                //recive the server home page page content.
                int bytes = 0;
                page = "Default HTML page on" + server + ":\r\n";

                do
                {
                    bytes = s.Receive(bytesReceived, bytesReceived.Length, 0);
                    page = page + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                }
                while (bytes > 0);
            }
            return page;
        }


        static void Main(string[] args)
        {
            string host;
            int port = 80;

            if (args.Length == 0)
                //if no server name is passed to the argument 
                host = Dns.GetHostName();
            //then ,using current host name as default.
            else
                host = args[0];

            string Result = SocketSendRecive(host, port);
            Console.WriteLine(Result);

        }
    }
}

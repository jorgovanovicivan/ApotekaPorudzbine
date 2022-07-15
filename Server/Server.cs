using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
 public   class Server
    {
        private Socket serverSocket;
        private List<ClientHandler> clients = new List<ClientHandler>();

      

        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }
        public bool Start()
        {
            try
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 20000);
                serverSocket.Bind(ep);
                serverSocket.Listen(8);
                return true;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
            
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket socket = serverSocket.Accept();
                    ClientHandler client = new ClientHandler(socket);
                    clients.Add(client);
                    client.OdjavljenKlijent += Handler_OdjavljenKlijent;
                    ClientHandler handler = new ClientHandler(socket);
                   // handler.HandlerRequests();
                    Thread nitKlijenta = new Thread(client.HandlerRequests);
                    nitKlijenta.IsBackground = false;
                    nitKlijenta.Start();

                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        public void Handler_OdjavljenKlijent(object sender, EventArgs args)
        {
            clients.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            serverSocket.Close();
            foreach (ClientHandler handler in clients.ToList())
            {
                handler.CloseSocket();
            }
            clients.Clear();
        }


    }
}

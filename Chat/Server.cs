using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Server
    {
        private TcpListener listener;
        private List<ServerConnectedClient> clients = new List<ServerConnectedClient>();

        public Server()
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
        }

        public IEnumerable<ServerConnectedClient> Clients
        {
            get
            {
                return clients;
            }
        }

        public async void Start()
        {
            listener.Start();
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                ServerConnectedClient connectedClient = new ServerConnectedClient(this, client);
                connectedClient.Start();
                clients.Add(connectedClient);
                
                
                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i] == null)
                    {
                        clients.Remove(clients[i]);
                    }
                }ClientConnected?.Invoke();
            }
        }
        public void Stop()
        {
            listener.Stop();
        }

        public event Action ClientConnected;
        public event Action ClientDisconnected; 
    }
}

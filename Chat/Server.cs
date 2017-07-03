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
        public bool IsRunning = false;
        public IEnumerable<ServerConnectedClient> Clients
        {
            get
            {
                return clients;
            }
        }

        public Server()
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
        }        

        public async void Start()
        {
            listener.Start();            
            IsRunning = true;
            while (IsRunning)
            {
                try
                {                    
                    TcpClient client = await listener.AcceptTcpClientAsync();
                    ServerConnectedClient connectedClient = new ServerConnectedClient(this, client);
                    connectedClient.Start();
                    clients.Add(connectedClient);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Test");
                }
            }
        }

        public void Stop()
        {
            listener.Stop();
            IsRunning = false;
        }

    }
}

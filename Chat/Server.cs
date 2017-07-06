using System;
using System.Collections.Generic;
using System.IO;
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

        public Dictionary<string, string> Users = new Dictionary<string, string>();
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
            //Users = File.ReadAllLines(Directory.GetCurrentDirectory()).ToDictionary(s => s.Split(' ')) ;
            string[] temp = File.ReadAllLines(@"./users.txt");
            foreach (string s in temp)
            {
                string[] c = s.Split(' ');
                Users.Add(c[0], c[1]);
            }
        }        

        public async void Start()
        {
            listener.Start();            
            IsRunning = true;
            StatusChanged?.Invoke();
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
                    System.Windows.Forms.MessageBox.Show("Server is stopped");
                }
            }
        }

        public void Stop()
        {
            listener.Stop();
            IsRunning = false;
            StatusChanged?.Invoke();            
        }

        public event Action StatusChanged;

    }
}

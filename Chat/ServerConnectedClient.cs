using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Chat
{
    public class ServerConnectedClient : ClientBase
    {
        private Server server;

        public ServerConnectedClient(Server server, TcpClient client) : base(client)
        {
            this.server = server;
            this.client = client;            
            RegisterHandler<MessageRequest>(Requests.Message, ProcessMessage);
        }

        private void ProcessMessage(MessageRequest request)
        {
            foreach (var clnt in server.Clients)
            {
                clnt.SendMessage(request.User, request.Message);
            }
        }

        public void Start()
        {
            new Thread(() => ClientProc(client)).Start();
        }

        private void ClientProc(TcpClient client)
        {
            using (client)
            {
                using (var stream = client.GetStream())
                {
                    writer = new BinaryWriter(stream);
                    reader = new BinaryReader(stream);
                    string temp = reader.ReadString();
                    writer.Write((int)Requests.ConnectionOk);                    
                    writer.Flush();
                    WorkWithClient();
                }
            }
        }
    }
}

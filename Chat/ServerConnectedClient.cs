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
            RegisterHandler<RequestMessage>(Requests.Message, ProcessMessage);
        }

        private void ProcessMessage(RequestMessage request)
        {
            foreach (var clnt in server.Clients)
            {
                clnt.SendMessage(request.Login, request.Message);
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
                    //string temp = reader.ReadString();
                    writer.Write((int)Requests.ConnectionOk);
                    writer.Flush();
                    Login = reader.ReadString();
                    Password = reader.ReadString();
                    writer.Write((int)CheckUser(Login, Password));
                    //!!!!!!!!!!!!!!!!!!!!!!!!!!
                    // !!  Check empty password
                    WorkWithClient();
                }
            }
        }

        private Requests CheckUser(string login, string password)
        {
            if (!server.Users.ContainsKey(login))
            {
                return Requests.LoginBad;
            }
            else if (!server.Users.TryGetValue(Login, out password))
            {
                return Requests.PasswordBad;
            }
            return Requests.LoginOk;
        }
    }
}

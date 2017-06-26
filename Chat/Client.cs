using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chat
{
    public class Client : ClientBase
    {
        public bool isConected;
        public Client() : base(new TcpClient())
        {
            RegisterHandler<MessageRequest>(Requests.Message, m => MessageReceived?.Invoke(m));
        }

        public bool Start(IPAddress address)
        {
            try
            {
                client.Connect(address, 8080);
                isConected = client.Connected;
                var stream = client.GetStream();
                writer = new BinaryWriter(stream);
                reader = new BinaryReader(stream);
                new Thread(WorkWithClient).Start();
                return (Requests)reader.ReadInt32() == Requests.ConnectionOk;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Cient start method");
                return false;
            }
        }

        //public void SendMessage(string login, string message)
        //{
        //    writer.Write((int)Requests.Message);
        //    writer.Write(login);
        //    writer.Write(message);
        //    writer.Flush();
        //}

        public event Action<MessageRequest> MessageReceived;
    }
}

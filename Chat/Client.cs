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
        public bool isConected
        {
            get
            {
                return client.Connected;
            }
        }
        public Client() : base(new TcpClient())
        {
            RegisterHandler<MessageRequest>(Requests.Message, m => MessageReceived?.Invoke(m));
        }

        public bool Start(IPAddress address)
        {
            try
            {
                client.Connect(address, 8080);
                var stream = client.GetStream();
                writer = new BinaryWriter(stream);
                reader = new BinaryReader(stream);
                bool result = (Requests)reader.ReadInt32() == Requests.ConnectionOk;
                new Thread(WorkWithClient).Start();
                Connected?.Invoke();
                return result;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Client start method");
                return false;
            }
        }
        
        public event Action<MessageRequest> MessageReceived;
        public event Func<bool> Connected;
        //public event Func<bool> Disconnected;
    }
}

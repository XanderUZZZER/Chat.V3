﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Chat
{
    public class Client : ClientBase
    {
        public Client(string login, string password) : base(new TcpClient())
        {
            Login = login;
            Password = password;
            RegisterHandler<RequestMessage>(Requests.Message, m => MessageReceived?.Invoke(m));
        }

        public void Start(IPAddress address, int port)
        {
            try
            {
                client.Connect(address, port);
                var stream = client.GetStream();
                writer = new BinaryWriter(stream);
                reader = new BinaryReader(stream);
                //bool result = (Requests)reader.ReadInt32() == Requests.ConnectionOk;
                if ((Requests)reader.ReadInt32() == Requests.ConnectionOk)
                {
                    writer.Write(Login);
                    writer.Write(Password);
                    writer.Flush();
                }
                new Thread(WorkWithClient).Start();
                //return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection error", 0, MessageBoxIcon.Error);
                //return false;
            }
        }

        public event Action<RequestMessage> MessageReceived;
    }
}

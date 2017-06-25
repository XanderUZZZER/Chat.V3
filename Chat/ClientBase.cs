using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public abstract class ClientBase
    {
        protected TcpClient client;
        protected BinaryReader reader;
        protected BinaryWriter writer;
        private Dictionary<Requests, Action> handlers = new Dictionary<Requests, Action>();

        public ClientBase(TcpClient client)
        {
            this.client = client;
        }

        protected void WorkWithClient()
        {
            while (true)
            {
                Requests request = (Requests)reader.ReadInt32();
                Action handler;
                if (handlers.TryGetValue(request, out handler))
                {
                    handler();
                }
                else
                {
                    throw new InvalidDataException();
                }
            }
        }

        protected void RegisterHandler<T>(Requests request, Action<T> action)
        {
            handlers[request] = () => ProcessResponse(action);
        }

        private void ProcessResponse<T>(Action<T> action)
        {
            Type t = typeof(T);
            var properties = t.GetProperties();
            object request = Activator.CreateInstance(t);
            foreach (var prop in properties)
            {
                prop.SetValue(request, ReadFromStream(prop.PropertyType));
            }
            action((T)request);
        }

        private object ReadFromStream(Type declaringType)
        {
            if (declaringType == typeof(Int32))
            {
                return reader.ReadInt32();
            }
            else if (declaringType == typeof(string))
            {
                return reader.ReadString();
            }

            throw new InvalidOperationException();
        }

        //public void SendMessage(string login, string message)
        //{
        //    writer.Write((int)Requests.Message);
        //    writer.Write(login);
        //    writer.Write(message);
        //    writer.Flush();
        //}
    }
}

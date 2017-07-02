using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat;
using System.Net;

namespace ChatClient
{
    public partial class ChatForm : Form
    {
        private Client client;

        public ChatForm(Client client, LoginForm loginForm)
        {
            //client = new Client();
            this.client = client;
            InitializeComponent();
            
            client.MessageReceived += Client_MessageReceived;
            loginForm.Hide();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            client.Start(IPAddress.Parse("127.0.0.1"), 8080);
        }

        private void Client_MessageReceived(RequestMessage obj)
        {
            BeginInvoke(new Action(() =>
                                    {
                                        tbChat.AppendText("\r\n" + obj.Login + " | " + obj.Message);
                                    }),
                        new object[0]);
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            client.SendMessage(client.Login, tbMessage.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Stop();
        }
    }
}

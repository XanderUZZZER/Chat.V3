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
    public partial class ClientMainForm : Form
    {
        private Client client;

        public ClientMainForm()
        {
            InitializeComponent();
            client.MessageReceived += Client_MessageReceived;
        }        

        private void btConnect_Click(object sender, EventArgs e)
        {
                //client = new Client();
                client.Start(IPAddress.Parse("127.0.0.1"));           
            
        }

        private void Client_MessageReceived(MessageRequest obj)
        {
            BeginInvoke(new Action(() =>
                                    {
                                        tbChat.AppendText("\r\n" + obj.User + "|" + obj.Message);
                                    }),
                        new object[0]);
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            client.SendMessage("user1", tbMessage.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Stop();
        }
    }
}

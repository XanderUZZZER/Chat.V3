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

namespace ChatServer
{
    public partial class ServerMainForm : Form
    {
        protected Server server = new Server();
        public ServerMainForm()
        {
            InitializeComponent();
            lbConnectedClients.Text = server.Clients.Count().ToString();
            server.ClientConnected += Server_ClientConnected;
        }

        private void Server_ClientConnected()
        {
            lbConnectedClients.Text = server.Clients.Count().ToString();
        }

        private void btServerStart_Click(object sender, EventArgs e)
        {
            server.Start();
            
        }
    }
}

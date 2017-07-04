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
    public partial class ServerForm : Form
    {
        protected Server server;
        protected string serverStatus
        {
            get
            {
                if (server.IsRunning)
                {
                    return "Server is runnig";
                }
                return "Server is stopped";
            }
        }
        public ServerForm()
        {
            InitializeComponent();
            server = new Server();
            server.StatusChanged += Server_StatusChanged;
            lbConnectedClients.Text = serverStatus;
        }

        private void Server_StatusChanged()
        {
            lbConnectedClients.Text = serverStatus;
        }

        private void btServerStart_Click(object sender, EventArgs e)
        {
            server.Start();
            //lbConnectedClients.Text = serverStatus;
        }

        private void btServerStop_Click(object sender, EventArgs e)
        {
            server.Stop();
        }
    }
}

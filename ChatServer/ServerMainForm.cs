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
        }

        private void btServerStart_Click(object sender, EventArgs e)
        {
            server.Start();
            lbConnectedClients.Text = server.isRunning.ToString();
        }
    }
}

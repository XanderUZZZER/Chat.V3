using Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class LoginForm : Form
    {
        private Client client;
        private ChatForm chatForm;

        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Client(tbName.Text, tbPassword.Text);
                client.Start(IPAddress.Parse(tbAddress.Text), Int32.Parse(tbPort.Text));
                if (client.IsConnected)
                {
                    chatForm = new ChatForm(client, this);
                    chatForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cbCustomAddress_CheckedChanged(object sender, EventArgs e)
        {
            tbAddress.Enabled = chbCustomAddress.Checked;
            tbPort.Enabled = chbCustomAddress.Checked;
        }

        private void tbName_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "Default name")
                tbName.Text = "";
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
                tbName.Text = "Default name";
        }
    }
}

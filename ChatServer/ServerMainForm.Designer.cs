namespace ChatServer
{
    partial class ServerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerMainForm));
            this.btServerStart = new System.Windows.Forms.Button();
            this.btServerStop = new System.Windows.Forms.Button();
            this.lbConnectedClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btServerStart
            // 
            this.btServerStart.Location = new System.Drawing.Point(12, 12);
            this.btServerStart.Name = "btServerStart";
            this.btServerStart.Size = new System.Drawing.Size(75, 23);
            this.btServerStart.TabIndex = 0;
            this.btServerStart.Text = "Start server";
            this.btServerStart.UseVisualStyleBackColor = true;
            this.btServerStart.Click += new System.EventHandler(this.btServerStart_Click);
            // 
            // btServerStop
            // 
            this.btServerStop.Location = new System.Drawing.Point(197, 226);
            this.btServerStop.Name = "btServerStop";
            this.btServerStop.Size = new System.Drawing.Size(75, 23);
            this.btServerStop.TabIndex = 1;
            this.btServerStop.Text = "Stop server";
            this.btServerStop.UseVisualStyleBackColor = true;
            this.btServerStop.Click += new System.EventHandler(this.btServerStop_Click);
            // 
            // lbConnectedClients
            // 
            this.lbConnectedClients.AutoSize = true;
            this.lbConnectedClients.Location = new System.Drawing.Point(13, 42);
            this.lbConnectedClients.Name = "lbConnectedClients";
            this.lbConnectedClients.Size = new System.Drawing.Size(35, 13);
            this.lbConnectedClients.TabIndex = 2;
            this.lbConnectedClients.Text = "label1";
            // 
            // ServerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbConnectedClients);
            this.Controls.Add(this.btServerStop);
            this.Controls.Add(this.btServerStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerMainForm";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerMainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btServerStart;
        private System.Windows.Forms.Button btServerStop;
        private System.Windows.Forms.Label lbConnectedClients;
    }
}


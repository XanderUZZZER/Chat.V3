namespace ChatClient
{
    partial class LoginForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.chbCustomAddress = new System.Windows.Forms.CheckBox();
            this.gbServerAddress = new System.Windows.Forms.GroupBox();
            this.gbServerAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(76, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Default name";
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(76, 34);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(151, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(12, 70);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(215, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(12, 112);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(215, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(34, 9);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(39, 13);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(12, 37);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(12, 157);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(215, 23);
            this.btRegister.TabIndex = 6;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(6, 16);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(9, 32);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(198, 20);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.Text = "255.255.255.255";
            // 
            // tbPort
            // 
            this.tbPort.Enabled = false;
            this.tbPort.Location = new System.Drawing.Point(9, 71);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(42, 20);
            this.tbPort.TabIndex = 10;
            this.tbPort.Text = "63999";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(6, 55);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(26, 13);
            this.lbPort.TabIndex = 9;
            this.lbPort.Text = "Port";
            // 
            // chbCustomAddress
            // 
            this.chbCustomAddress.AutoSize = true;
            this.chbCustomAddress.Location = new System.Drawing.Point(106, 74);
            this.chbCustomAddress.Name = "chbCustomAddress";
            this.chbCustomAddress.Size = new System.Drawing.Size(101, 17);
            this.chbCustomAddress.TabIndex = 11;
            this.chbCustomAddress.Text = "Custom address";
            this.chbCustomAddress.UseVisualStyleBackColor = true;
            this.chbCustomAddress.CheckedChanged += new System.EventHandler(this.cbCustomAddress_CheckedChanged);
            // 
            // gbServerAddress
            // 
            this.gbServerAddress.Controls.Add(this.lbAddress);
            this.gbServerAddress.Controls.Add(this.chbCustomAddress);
            this.gbServerAddress.Controls.Add(this.tbAddress);
            this.gbServerAddress.Controls.Add(this.tbPort);
            this.gbServerAddress.Controls.Add(this.lbPort);
            this.gbServerAddress.Location = new System.Drawing.Point(12, 195);
            this.gbServerAddress.Name = "gbServerAddress";
            this.gbServerAddress.Size = new System.Drawing.Size(213, 100);
            this.gbServerAddress.TabIndex = 12;
            this.gbServerAddress.TabStop = false;
            this.gbServerAddress.Text = "Server";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 304);
            this.Controls.Add(this.gbServerAddress);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.gbServerAddress.ResumeLayout(false);
            this.gbServerAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.CheckBox chbCustomAddress;
        private System.Windows.Forms.GroupBox gbServerAddress;
    }
}
namespace UniversalWinVPN
{
    partial class VPNCreateForm
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
            this.txt_VpnName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ServerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.btn_CreateVpn = new System.Windows.Forms.Button();
            this.btn_ConnectVpn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.btn_fixReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_VpnName
            // 
            this.txt_VpnName.Location = new System.Drawing.Point(186, 44);
            this.txt_VpnName.Name = "txt_VpnName";
            this.txt_VpnName.Size = new System.Drawing.Size(100, 21);
            this.txt_VpnName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "VPN Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server IP";
            // 
            // txt_ServerIP
            // 
            this.txt_ServerIP.Location = new System.Drawing.Point(186, 71);
            this.txt_ServerIP.Name = "txt_ServerIP";
            this.txt_ServerIP.Size = new System.Drawing.Size(100, 21);
            this.txt_ServerIP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(186, 125);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(100, 21);
            this.txt_Pwd.TabIndex = 4;
            // 
            // btn_CreateVpn
            // 
            this.btn_CreateVpn.Location = new System.Drawing.Point(128, 159);
            this.btn_CreateVpn.Name = "btn_CreateVpn";
            this.btn_CreateVpn.Size = new System.Drawing.Size(156, 23);
            this.btn_CreateVpn.TabIndex = 7;
            this.btn_CreateVpn.Text = "Create Vpn Connection";
            this.btn_CreateVpn.UseVisualStyleBackColor = true;
            this.btn_CreateVpn.Click += new System.EventHandler(this.btn_CreateVpn_Click);
            // 
            // btn_ConnectVpn
            // 
            this.btn_ConnectVpn.Location = new System.Drawing.Point(128, 188);
            this.btn_ConnectVpn.Name = "btn_ConnectVpn";
            this.btn_ConnectVpn.Size = new System.Drawing.Size(156, 23);
            this.btn_ConnectVpn.TabIndex = 8;
            this.btn_ConnectVpn.Text = "Connect To Vpn";
            this.btn_ConnectVpn.UseVisualStyleBackColor = true;
            this.btn_ConnectVpn.Click += new System.EventHandler(this.btn_ConnectVpn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "UserName";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(186, 98);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 21);
            this.txt_UserName.TabIndex = 9;
            // 
            // btn_fixReg
            // 
            this.btn_fixReg.Location = new System.Drawing.Point(128, 217);
            this.btn_fixReg.Name = "btn_fixReg";
            this.btn_fixReg.Size = new System.Drawing.Size(156, 23);
            this.btn_fixReg.TabIndex = 11;
            this.btn_fixReg.Text = "Fix registry";
            this.btn_fixReg.UseVisualStyleBackColor = true;
            this.btn_fixReg.Click += new System.EventHandler(this.btn_fixReg_Click);
            // 
            // VPNCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 371);
            this.Controls.Add(this.btn_fixReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_ConnectVpn);
            this.Controls.Add(this.btn_CreateVpn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ServerIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_VpnName);
            this.Name = "VPNCreateForm";
            this.Text = "VPNCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_VpnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ServerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Button btn_CreateVpn;
        private System.Windows.Forms.Button btn_ConnectVpn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button btn_fixReg;
    }
}
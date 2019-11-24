using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversalWinVPN
{
    public partial class VPNCreateForm : Form
    {
        public VPNCreateForm()
        {
            InitializeComponent();
        }

        private void btn_CreateVpn_Click(object sender, EventArgs e)
        {
            CreateConnection createConn = new CreateConnection();
            try
            {
                createConn.CreateVPN(txt_VpnName.Text, txt_ServerIP.Text);
                MessageBox.Show("Create VPN Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ConnectVpn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnection createConn = new CreateConnection();
                createConn.ConnectVPN(txt_VpnName.Text,txt_UserName.Text,txt_Pwd.Text);
                MessageBox.Show("Connect to VPN Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_fixReg_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnection createConn = new CreateConnection();
                createConn.FixReg();
                MessageBox.Show("Fix registry success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

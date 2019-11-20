using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;

namespace UniversalWinVPN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = ConfigurationManager.AppSettings["ConnectionName"];
            textBox2.Text = ConfigurationManager.AppSettings["DestinationAddress"];
            checkBox2.Checked = Boolean.Parse(ConfigurationManager.AppSettings["UseWinCreds"]);
            if (ConfigurationManager.AppSettings["L2TP"] == "")
            {
                checkBox1.Checked = false;
            }
            else 
            {
                checkBox1.Checked = true;
                textBox3.Text = ConfigurationManager.AppSettings["L2TP"];
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string l2tp = textBox3.Text;
                var worker = new CreateConnection();
                worker.CreateVPN(textBox1.Text, textBox2.Text, l2tp, checkBox2.Checked);
            }
            else
            {
                string l2tp = "1";
                var worker = new CreateConnection();
                worker.CreateVPN(textBox1.Text, textBox2.Text, l2tp, checkBox2.Checked);
            }
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = checkBox1.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

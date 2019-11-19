using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DotRas;

namespace UniversalWinVPN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[2] == null)
                {
                    Console.WriteLine("Please enter arguments as follows: 'name' 'destination' 'l2tp' 'use login (true or false)'" + "Press Any Key to Exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    var worker = new CreateConnection();
                    worker.CreateVPN(args[0], args[1], args[2], Boolean.Parse(args[3]));
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }

    public class CreateConnection
    {
        public int CreateVPN(string name, string destination, string l2tp, bool useLogin)
        {
            try
            {
                RasPhoneBook PhoneBook = new RasPhoneBook();
                PhoneBook.Open();
                if (l2tp == "1")
                {
                    var strat = RasVpnStrategy.PptpOnly;
                    RasEntry VPNEntry = RasEntry.CreateVpnEntry(name, destination, strat, DotRas.RasDevice.Create(name, DotRas.RasDeviceType.Vpn));
                    VPNEntry.Options.UsePreSharedKey = false;
                    VPNEntry.Options.UseLogOnCredentials = useLogin;
                    PhoneBook.Entries.Add(VPNEntry);
                    MessageBox.Show("PPTP VPN Created Succesfully!");
                    return 1;
                }
                else
                {
                    var strat = RasVpnStrategy.L2tpOnly;
                    RasEntry VPNEntry = RasEntry.CreateVpnEntry(name, destination, strat, DotRas.RasDevice.Create(name, DotRas.RasDeviceType.Vpn));
                    VPNEntry.Options.UsePreSharedKey = true;
                    VPNEntry.Options.UseLogOnCredentials = useLogin;
                    PhoneBook.Entries.Add(VPNEntry);
                    VPNEntry.UpdateCredentials(RasPreSharedKey.Client, l2tp);
                    MessageBox.Show("L2TP VPN Created Succesfully!");
                    return 2;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("VPN Creation Failure");
                return 0;
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DotRas.Design;
using Microsoft.Win32;
using DotRas;
using System.Net;

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
                if(args[0] == "create")
                {
                    CreateConnection createConn = new CreateConnection();
                    createConn.CreateVPN(args[1], args[2]);
                }
                else if (args[0] == "connect")
                {
                    CreateConnection createConn = new CreateConnection();
                    createConn.ConnectVPN(args[1], args[2],args[3]);
                }
                else if(args[0] == "fixReg")
                {
                    CreateConnection createConn = new CreateConnection();
                    createConn.FixReg();
                }
                else
                {
                    Console.WriteLine("WRONG COMMAND!");
                    Console.WriteLine("create <name> <destination>                    create a new vpn");
                    Console.WriteLine("connect <name> <username> <pwd>      connect to a vpn");
                    Console.WriteLine("fixReg                                                           fix registry");
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new VPNCreateForm());
            }
        }
    }

    public class CreateConnection
    {
        public void CreateVPN(string name, string destination)
        {
            RasPhoneBook PhoneBook = new RasPhoneBook();
            PhoneBook.Open();

            RasVpnStrategy strategy = RasVpnStrategy.L2tpOnly;  // Set your strategy here

            RasEntry VPNEntry = RasEntry.CreateVpnEntry(name, destination, strategy, DotRas.RasDevice.Create(name, DotRas.RasDeviceType.Vpn));
            PhoneBook.Entries.Add(VPNEntry);

            Console.WriteLine("Create VPN Success!");
        }

        public void ConnectVPN(string name,string userName,string pwd)
        {
            RasPhoneBook PhoneBook = new RasPhoneBook();
            PhoneBook.Open();

            RasDialer dialer = new RasDialer();
            dialer.EntryName = name;
            dialer.PhoneBookPath = PhoneBook.Path;

            dialer.Credentials = new NetworkCredential(userName, pwd);
            dialer.Dial();

            Console.WriteLine("Connect to VPN Success!");
        }

        public void FixReg()
        {
            const string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\PolicyAgent";
            const string valueName = "AssumeUDPEncapsulationContextOnSendRule";
            const int value = 2;

            Registry.SetValue(keyName, valueName, value);
        }
    }
}



﻿using ChatApp.Servise;
using ChatContracts.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var uris = new Uri[1];
            string adr = "net.tcp://localhost:6565/MessageService";
            uris[0] = new Uri(adr);
            IMessageService service = new MessageService();
            ServiceHost host = new ServiceHost(service, uris);
            var binding = new NetTcpBinding(SecurityMode.None);
            host.AddServiceEndpoint(typeof(IMessageService), binding, string.Empty);
            host.Opened += HostOnOpened;
            host.Open();
            Console.ReadLine();
        }

        private static void HostOnOpened(object sender, EventArgs e)
        {
            Console.WriteLine("Tcp Service Started");
        }
    }
}

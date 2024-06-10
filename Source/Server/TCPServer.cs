using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class TCPServer
    {
        private TcpListener server = null
        public void StartServer(int port)
        {
            try
            {
                InitializeServer(port);
            }

        }

        public string InitializeServer(int port)
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            server = new TcpListener(localAddr, port);
            string log = "Сервер запущен. Ожидание подключений...\n"
        }
    }
}

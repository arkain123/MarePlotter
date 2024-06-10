using System;
using System.Text;
using System.Net.Sockets;

namespace Client
{
    internal class TCPClient
    {
        private TcpClient tcpClient = new TcpClient();
        private NetworkStream stream;

        private void Connect(string address, int port)
        {
            tcpClient.Connect(address, port);
        }

        private void Disconnect()
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
        }

        private void Send(string msg)
        {
            stream = tcpClient.GetStream();
            byte[] convertedMsg = Encoding.UTF8.GetBytes(msg);

            stream.Write(convertedMsg, 0, convertedMsg.Length);
        }

        private string Receive(int streamsize)
        {
            stream = tcpClient.GetStream();

            byte[] responseData = new byte[streamsize];
            StringBuilder response = new StringBuilder();
            int bytes = stream.Read(responseData, 0, responseData.Length);

            response.Append(Encoding.UTF8.GetString(responseData, 0, bytes));

            return response.ToString();
        }

        public string[] Handshake(string msg, string address, int port, int streamsize)
        {
            try
            {
                Connect(address, port);
                Send(msg);
                string receivedMsg = Receive(streamsize);
                Disconnect();
                string[] completedata = receivedMsg.Split('~');
                return completedata;
            }
            catch (Exception e)
            {
                string[] errmsg = new string[1];
                errmsg[0] = e.GetType().ToString();
                return errmsg;
            }
        }
    }
}

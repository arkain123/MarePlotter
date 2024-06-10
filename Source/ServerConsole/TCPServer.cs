using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    internal class TCPServer
    {
        TcpListener server = null;
        NetworkStream stream = null;
        private Algorithm algo = new Algorithm();

        public void StartServer(int port)
        {
            try
            {
                InitializeServer(port);
                while (true)
                {
                    ReceiveAndSend();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                server.Stop();
            }
        }

        private void InitializeServer(int port)
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            server = new TcpListener(localAddr, port);

            server.Start();

            Console.WriteLine("Сервер запущен. Ожидание подключений...");
        }

        private void ReceiveAndSend()
        {
            TcpClient client = server.AcceptTcpClient();

            Console.WriteLine("Клиент подключен.");

            stream = client.GetStream();

            byte[] data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);

            string requestData = Encoding.UTF8.GetString(data, 0, bytes);
            Console.WriteLine("Полученные данные: {0}", requestData);
            string[] splittedData = requestData.Split('~');
            algo.SetValues(
                double.Parse(splittedData[0]),
                double.Parse(splittedData[1]),
                double.Parse(splittedData[2]),
                double.Parse(splittedData[3]),
                splittedData[4]
                );

            string responseData = "";
            string[] points = new string[1];
            try
            {
                points = algo.Solve();
            }
            catch (Exception e) { }
            for (int i = 1; i < points.Length; i += 2)
            {
                responseData += points[i - 1];
                responseData += '~';
                responseData += points[i];
                responseData += '~';
                Console.WriteLine(points[i - 1] + "   " + points[i]);
            }
            try
            {
                responseData = responseData.Remove(responseData.Length - 1);
            } catch (Exception e) { }
            byte[] responseBytes = Encoding.UTF8.GetBytes(responseData);

            stream.Write(responseBytes, 0, responseBytes.Length);
            Console.WriteLine("Ответ отправлен клиенту.");

            client.Close();
            
        }
    }
}

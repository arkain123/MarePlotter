namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PORT = 11208;
            
            TCPServer server = new TCPServer();
            server.StartServer(PORT);
        }
    }
}

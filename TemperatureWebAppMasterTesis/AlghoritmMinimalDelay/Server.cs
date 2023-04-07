using System.Net.Sockets;

namespace TemperatureWebAppMasterTesis.AlghoritmMinimalDelay
{
    public class Server
    {   
        //public string IpAddress { get; set; }
        //public int Port { get; set; }

        //public Server() { }
        //public Server(string ipAddress, int port)
        //{
        //    IpAddress = ipAddress;
        //    Port = port;
        //}       

        public bool ServerPing(string address, int port)
        {
            bool serviceOnline;

            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(address, port);
                serviceOnline = true;     // Service is online. No exception thrown.
            }
            catch (Exception)
            {
                serviceOnline = false;    // Exception was thrown. Service is offline
            }

            return serviceOnline;


        }
    }
}

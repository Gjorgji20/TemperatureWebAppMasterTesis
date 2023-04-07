using Microsoft.AspNetCore.Hosting.Server;
using ServerClient;

namespace TemperatureWebAppMasterTesis.AlghoritmMinimalDelay
{
    public class MinimalDelay
    {
      
        public MinimalDelay()
        { }

        public void MinimalDelayResult()
        {
            Task.WaitAll(Task.Run(async () =>
            {
                Server server1=new Server();
                if(server1.ServerPing("192.168.100.24", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.24/Temperature");
                    await ServerClient.GetTemperature();
                }else if(server1.ServerPing("192.168.100.15", 443))
                    {
                    Client ServerClient = new Client("https://192.168.100.15/Temperature");
                    await ServerClient.GetTemperature();
                }

               
            }), Task.Run(async () =>
            {

                Server server1 = new Server();
                if (server1.ServerPing("192.168.100.15", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.15/Temperature");
                    await ServerClient.GetTemperature();
                }
                else if (server1.ServerPing("192.168.100.24", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.24/Temperature");
                    await ServerClient.GetTemperature();
              
                }

               
            }));
        }
    }
}

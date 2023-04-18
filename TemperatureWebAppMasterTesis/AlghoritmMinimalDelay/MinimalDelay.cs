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
                var timeReq = DateTime.Now;
                
                Server server1=new Server();
                if(server1.ServerPing("192.168.100.24", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.24/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds=Math.Abs(timeRes.Second- timeReq.Second);
                    var delayMiliSecond=Math.Abs(timeReq.Millisecond- timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:"+timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() +"\n Delay miliseconds:"+ delayMiliSecond.ToString()+"\n Total Delay in miliseconds:"+ TotalDelay.ToString()+ "\n Average Total Delay:"+TotalDelayAverage.ToString());
                }
                else if (server1.ServerPing("192.168.100.24", 7188))
                {
                    Client ServerClient = new Client("https://192.168.100.24:7188/api/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
                else if(server1.ServerPing("192.168.100.15", 443))
                    {
                    Client ServerClient = new Client("https://192.168.100.15/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
            }), Task.Run(async () =>
            {
                var timeReq = DateTime.Now;

                Server server1 = new Server();
                if (server1.ServerPing("192.168.100.15", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.15/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
                else if (server1.ServerPing("192.168.100.24", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.24/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
                else if (server1.ServerPing("192.168.100.24", 7188))
                {
                    Client ServerClient = new Client("https://192.168.100.24:7188/api/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
            }),
            Task.Run(async () =>
            {
                var timeReq = DateTime.Now;

                Server server1 = new Server();
                if (server1.ServerPing("192.168.100.24", 7188))
                {
                    Client ServerClient = new Client("https://192.168.100.24:7188/api/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
                else if (server1.ServerPing("192.168.100.15", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.15/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
                else if (server1.ServerPing("192.168.100.24", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.24/Temperature");
                    await ServerClient.GetTemperature();
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                }
            }));
        }
    }
}

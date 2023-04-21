using Microsoft.AspNetCore.Hosting.Server;
using ServerClient;
using TemperatureWebAppMasterTesis.Models;

namespace TemperatureWebAppMasterTesis.AlghoritmMinimalDelay
{
    public class MinimalDelay
    {
      
        public MinimalDelay()
        { }

        public async void MinimalDelayResult()
        {
         var res=  await Task.WhenAny<Responce>(Task.Run<Responce>(async () =>
            {
                var timeReq = DateTime.Now;
                Responce responce=new Responce();
                Server server1 = new Server();
                if (server1.ServerPing("192.168.100.24", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.24/temperature");
                    var temp= ServerClient.GetTemperature().Result;
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                    //Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                    responce.Temp= temp;
                    responce.Server="https://192.168.100.24/temperature";
                    responce.DelaySeconds=delaySeconds;
                    responce.DelayMiliSecond=delayMiliSecond;
                    responce.TotalDelay = TotalDelay;
                    responce.TotalDelayAverage= TotalDelayAverage;
                    return responce;

                }
                else if (server1.ServerPing("192.168.100.15", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.15/temperature");
                    var temp= ServerClient.GetTemperature().Result;
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                  //  Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                    responce.Temp= temp;
                    responce.Server = "https://192.168.100.15/temperature";
                    responce.DelaySeconds = delaySeconds;
                    responce.DelayMiliSecond = delayMiliSecond;
                    responce.TotalDelay = TotalDelay;
                    responce.TotalDelayAverage = TotalDelayAverage;
                    return responce;

                }
                else
                {
                    return null;
                }
            }), Task.Run<Responce>(async () =>
            {
                var timeReq = DateTime.Now;
                Responce responce=new Responce();
                Server server1 = new Server();
                if (server1.ServerPing("192.168.100.15", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.15/temperature");
                    var temp= ServerClient.GetTemperature().Result;
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                  //  Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                    responce.Temp= temp;
                    responce.Server = "https://192.168.100.24/temperature";
                    responce.DelaySeconds = delaySeconds;
                    responce.DelayMiliSecond = delayMiliSecond;
                    responce.TotalDelay = TotalDelay;
                    responce.TotalDelayAverage = TotalDelayAverage;
                    return responce;
                }
                else if (server1.ServerPing("192.168.100.24", 443))
                {
                    Client ServerClient = new Client("https://192.168.100.24/temperature");
                    var temp= ServerClient.GetTemperature().Result;
                    var timeRes = DateTime.Now;
                    var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
                    var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
                    var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
                    var TotalDelayAverage = TotalDelay / 2;
                   // Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
                    responce.Temp= temp;
                    responce.Server = "https://192.168.100.24/temperature";
                    responce.DelaySeconds = delaySeconds;
                    responce.DelayMiliSecond = delayMiliSecond;
                    responce.TotalDelay = TotalDelay;
                    responce.TotalDelayAverage = TotalDelayAverage;
                    return responce;
                }
                else
                {
                    return null;
                }
            }));

            Console.WriteLine("Server: "+res.Result.Server+"\nCelsius: "+ res.Result.Temp.Celsius.ToString()+ "\nFahrenheit: "+res.Result.Temp.Fahrenheit+
                "\nTotdalDelay: "+res.Result.TotalDelay);

        }
        //public void MinimalDelayResult()
        //{
        //    Task.WaitAll(Task.Run(async () =>
        //    {
        //        var timeReq = DateTime.Now;

        //        Server server1 = new Server();
        //        if (server1.ServerPing("192.168.100.24", 443))
        //        {
        //            Client ServerClient = new Client("https://192.168.100.24/temp");
        //            await ServerClient.GetTemperature();
        //            var timeRes = DateTime.Now;
        //            var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
        //            var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
        //            var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
        //            var TotalDelayAverage = TotalDelay / 2;
        //            Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
        //        }
        //        else if (server1.ServerPing("192.168.100.15", 443))
        //        {
        //            Client ServerClient = new Client("https://192.168.100.15/temp");
        //            await ServerClient.GetTemperature();
        //            var timeRes = DateTime.Now;
        //            var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
        //            var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
        //            var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
        //            var TotalDelayAverage = TotalDelay / 2;
        //            Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
        //        }
        //    }), Task.Run(async () =>
        //    {
        //        var timeReq = DateTime.Now;

        //        Server server1 = new Server();
        //        if (server1.ServerPing("192.168.100.15", 443))
        //        {
        //            Client ServerClient = new Client("https://192.168.100.15/temp");
        //            await ServerClient.GetTemperature();
        //            var timeRes = DateTime.Now;
        //            var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
        //            var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
        //            var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
        //            var TotalDelayAverage = TotalDelay / 2;
        //            Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
        //        }
        //        else if (server1.ServerPing("192.168.100.24", 443))
        //        {
        //            Client ServerClient = new Client("https://192.168.100.24/temp");
        //            await ServerClient.GetTemperature();
        //            var timeRes = DateTime.Now;
        //            var delaySeconds = Math.Abs(timeRes.Second - timeReq.Second);
        //            var delayMiliSecond = Math.Abs(timeReq.Millisecond - timeRes.Millisecond);
        //            var TotalDelay = delaySeconds * 1000 + delayMiliSecond;
        //            var TotalDelayAverage = TotalDelay / 2;
        //            Console.WriteLine("TimeRequest:" + timeReq.ToString("dd:MM:yyyy h:mm:ss fff") + "\n TimeResponce:" + timeRes.ToString("dd:MM:yyyy h:mm:ss fff") + "\n Delay Second:" + delaySeconds.ToString() + "\n Delay miliseconds:" + delayMiliSecond.ToString() + "\n Total Delay in miliseconds:" + TotalDelay.ToString() + "\n Average Total Delay:" + TotalDelayAverage.ToString());
        //        }
        //    }));
        //}
    }
}

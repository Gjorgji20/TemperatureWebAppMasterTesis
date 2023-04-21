using ServerClient;

namespace TemperatureWebAppMasterTesis.Models
{
    public class Responce
    {
        public Temperature Temp { get; set; }
        public string Server { get; set; }
        public int DelaySeconds { get; set; }
        public int DelayMiliSecond { get; set; }
        public int TotalDelay { get; set; }
        public int TotalDelayAverage { get;set; }
    }
}

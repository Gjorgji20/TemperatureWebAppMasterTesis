using Newtonsoft.Json;

namespace ServerClient
{
    public class Client
    {
        public string Url { get; set; }
        public Client(string url)
        {
            Url = url;
        }
        HttpClientHandler clientHandler = new HttpClientHandler();
        public async Task/*Task<Temperature>*/ GetTemperature()
        {
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            Temperature temperature = null;

            using (var client = new System.Net.Http.HttpClient(clientHandler))
            {

                var response = await client.GetAsync(Url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    temperature = JsonConvert.DeserializeObject<Temperature>(jsonString);
                }
                //return temperature;
                Console.WriteLine(Url + ": " + temperature.Celsius.ToString());
            }
        }

    }
}
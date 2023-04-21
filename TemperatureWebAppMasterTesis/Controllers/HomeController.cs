using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Sockets;
using TemperatureWebAppMasterTesis.AlghoritmMinimalDelay;
using TemperatureWebAppMasterTesis.Models;

namespace TemperatureWebAppMasterTesis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public MinimalDelay Delay { get; set; }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Delay = new MinimalDelay();
        }

       public async Task<IActionResult> Index()
        {
            int i = 1;
            while (true)
            {
                Console.WriteLine("Iteration" + i.ToString());
                Delay.MinimalDelayResult();
                await Task.Delay(6000);
                Console.WriteLine("-------------------");
                i++;

            }
            return View();
        }
        public IActionResult Privacy()
        {
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}





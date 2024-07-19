using Kubernetes.Sbc.Ui.Web.Models;
using Kubernetes.Sbc.Ui.Web.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace Kubernetes.Sbc.Ui.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly HttpClient _httpClient;

        public HomeController(
            ILogger<HomeController> logger,
            HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index(string continent)
        {
            IEnumerable<WeatherForecast>? model = Array.Empty<WeatherForecast>();
            switch (continent)
            {
                case "asia":
                    model = await _httpClient
                        .GetFromJsonAsync<IEnumerable<WeatherForecast>>($"{Env.WEATHER_SERVICE}/WeatherForecast");
                    break;
                //case "europe":
                //    model = await _httpClient
                //        .GetFromJsonAsync<IEnumerable<WeatherForecast>>($"{Env.SERVICE_EUROPE_WEATHER}/WeatherForecast");
                //    break;
                //case "south-america":
                //    model = await _httpClient
                //        .GetFromJsonAsync<IEnumerable<WeatherForecast>>($"{Env.SERVICE_SOUTHAMERICA_WEATHER}/WeatherForecast");
                //    break;
            }

            return View(model);
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

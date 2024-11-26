using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeatherService _weatherService;

        public HomeController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                ViewBag.Error = "City name cannot be empty.";
                return View();
            }

            try
            {
                var weather = await _weatherService.GetWeatherAsync(city);
                return View(weather);
            }
            catch
            {
                ViewBag.Error = "Could not fetch weather data. Please try again.";
                return View();
            }
        }
    }
}

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public WeatherService(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<WeatherModel> GetWeatherAsync(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={_apiKey}";
            var response = await _httpClient.GetStringAsync(url);
            dynamic weatherData = JsonConvert.DeserializeObject(response);

            return new WeatherModel
            {
                City = weatherData.name,
                Temperature = weatherData.main.temp,
                Condition = weatherData.weather[0].description
            };
        }
    }
}

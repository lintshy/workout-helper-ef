using System.Net.Http;
using Newtonsoft.Json;
using workout_helper_2.Models;

namespace workout_helper_2.Services
{
    public class B2BService : IB2BService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<B2BService> _logger;

        public B2BService(HttpClient httpClient, ILogger<B2BService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<WeatherResponse> GetCurrentWeather()
        {

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/current.json?q=53.1%2C-0.13"),
                Headers =
                        {
        { "X-RapidAPI-Key", "fe6eedcc6bmsh09c09b12622d6b0p1bb769jsn97b60634ddc3" },
        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
    },
            };
            var result = new WeatherResponse();
            try
            {
                var response = await _httpClient.SendAsync(request);
                var body = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<WeatherResponse>(body);
                _logger.LogInformation("result");
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Warning, ex, ex.Message);

            }
            return result;
        }


    }
}

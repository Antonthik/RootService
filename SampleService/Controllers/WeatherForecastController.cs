using Microsoft.AspNetCore.Mvc;
using RootServiceNamespace;

namespace SampleService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public /*IEnumerable<WeatherForecast>*/ async Task<IEnumerable<WeatherForecast>> Get()
        {
            RootServiceClient rootServiceClient = new RootServiceClient("http://localhost:5051",new HttpClient());

            return await rootServiceClient.GetWeatherForecastAsync();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
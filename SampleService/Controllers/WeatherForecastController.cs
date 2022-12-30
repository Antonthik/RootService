using Microsoft.AspNetCore.Mvc;
using RootServiceNamespace;
using SampleService.Services;

namespace SampleService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRootServiceClient _rootServiceClient;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRootServiceClient rootServiceClient)
        {
            _logger = logger;
            _rootServiceClient = rootServiceClient;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _rootServiceClient.Get();
        }
    }
}
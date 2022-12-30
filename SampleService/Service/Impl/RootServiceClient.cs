using RootServiceNamespace;

namespace SampleService.Services.Impl
{
    public class RootServiceClient : IRootServiceClient
    {

        #region Services

        private readonly ILogger<RootServiceClient> _logger;
        private RootServiceNamespace.RootServiceClient _rootServiceClient;

        #endregion

        public RootServiceClient(HttpClient httpClient,
            ILogger<RootServiceClient> logger)
        {
            _logger = logger;
            _rootServiceClient = new RootServiceNamespace.RootServiceClient("http://localhost:5051/", httpClient);
        }

        public RootServiceNamespace.RootServiceClient Client => _rootServiceClient;

        public async Task<ICollection<RootServiceNamespace.WeatherForecast>> Get()
        {
            return await _rootServiceClient.GetWeatherForecastAsync();
        }
    }
}

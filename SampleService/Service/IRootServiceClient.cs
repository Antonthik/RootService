namespace SampleService.Services
{
    public interface IRootServiceClient
    {
        public RootServiceNamespace.RootServiceClient Client { get; }

        public Task<ICollection<RootServiceNamespace.WeatherForecast>> Get();
    }
}


using Signum.NET;
using System.Net.Http;

using System.Reflection;
using System.Text;
/// <summary>
///Example for basic usage of Signum.NET
/// </summary>
namespace Signum
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;               
        private readonly IHttpClientFactory _clientFactory;

        public Worker(ILogger<Worker> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _clientFactory = httpClientFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                HttpClient  Client = _clientFactory.CreateClient();

                //Setup Signum Node API URI in appsettings file and update HttpClient
                Client.BaseAddress = new Uri(_configuration["SignumNodeUri"]);
                //Pass in HttpClient to Signum API Service
                ISignumAPIService SignumService = new SignumAPIService(Client);


                var result = await SignumService.GetTime();
                var result2 = await SignumService.GetMiningInfo();
                var result3 = await SignumService.GetState() ;

                if(result != null)
                {
                    _logger.LogWarning(result.GetType().Name);
                    _logger.LogInformation(result.PrintInterfaceData());
                }
                

                if(result2 != null)
                {
                    _logger.LogWarning(result2.GetType().Name);
                    _logger.LogInformation(result2.PrintInterfaceData());
                }

                if(result3 != null)
                {
                    _logger.LogWarning(result3.GetType().Name);
                    _logger.LogInformation(result3.PrintInterfaceData());
                                                       
               
                }



                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}
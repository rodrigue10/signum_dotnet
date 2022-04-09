
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
                var result3 = await SignumService.GetState(includeCounts: "true", apiKey:"signumpassword") ;

                if(result != null)
                {
                    _logger.LogInformation($"{{resultTime}}", result.Time);
                }
                

                if(result2 != null)
                {

                    _logger.LogInformation(message: $"{{height}} - {{error}} - {{errDescrip}}", result2.Height, result2.ErrorCode, result2.ErrorDescription)  ;
                }

                if(result3 != null)
                {
                    if (result3.IsValidRequest)
                    {
                        StringBuilder sbHead = new();

                        foreach (var item in typeof(IGetState).GetProperties())
                        {
                            sbHead.Append(item.Name);
                            sbHead.Append(" - ");
                            sbHead.Append(item.GetValue(result3));
                            sbHead.AppendLine();

                        }
                        _logger.LogInformation($"{{sbHead}}", sbHead);
                    }
                    else
                    {
                        StringBuilder sbHead = new();

                        foreach (var item in typeof(IBaseRequest).GetProperties())
                        {
                            sbHead.Append(item.Name);
                            sbHead.Append(" - ");
                            sbHead.Append(item.GetValue(result3));
                            sbHead.AppendLine();

                        }
                        _logger.LogInformation($"{{sbHead}}", sbHead);
                    }

                    
               
                }





                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
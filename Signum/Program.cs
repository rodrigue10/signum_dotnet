using Signum;


IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //Add HttpClientFactory Service to DI Container
        services.AddHttpClient();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();

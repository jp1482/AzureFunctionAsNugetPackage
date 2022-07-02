using AzureFunctionAsPackage.Helper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddScoped<IAppVersionProvider,EnvironmentAppVersionProvider>();
    })
    .Build();

host.Run();
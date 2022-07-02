using HealthAzureFunctions;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services => services.AddHealthFunctionExtensions())
    .Build();

host.Run();
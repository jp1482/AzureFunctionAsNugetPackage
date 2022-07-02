using Microsoft.Extensions.DependencyInjection;

namespace HealthAzureFunctions
{
    public static class HealthFunctionExtensions
    {
        public static IServiceCollection AddHealthFunctionExtensions(this IServiceCollection services)
        {
            services.AddTransient<IAppVersionProvider,EnvironmentAppVersionProvider>();
            return services;
        }
    }
}

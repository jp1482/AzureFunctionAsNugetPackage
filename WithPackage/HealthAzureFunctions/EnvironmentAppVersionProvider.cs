namespace HealthAzureFunctions
{
    public class EnvironmentAppVersionProvider : IAppVersionProvider
    {
        public string GetVersion()
        {
            return Environment.GetEnvironmentVariable("AppVersion") ?? "Not Available";
        }
    }
}

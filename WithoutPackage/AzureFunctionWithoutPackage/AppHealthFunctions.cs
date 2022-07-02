using System.Collections.Generic;
using System.Net;
using AzureFunctionAsPackage.Helper;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionAsPackage
{
    public class AppHealthFunctions
    {
        private readonly IAppVersionProvider appVersionProvider;
        public AppHealthFunctions(IAppVersionProvider appVersionProvider)
        {            
            this.appVersionProvider = appVersionProvider;
        }

        [Function("health")]
        public async Task<HttpResponseData> GetFunctionHealth(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "service/health")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);            
            await response.WriteAsJsonAsync(new 
            { 
                Status = "running", 
                Machinename = Environment.MachineName,
                Version = this.appVersionProvider.GetVersion()
            });
            return response;
        }        
    }
}

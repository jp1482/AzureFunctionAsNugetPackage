using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionAsPackage
{
    public class SimpleBusinessFunctions
    {
        private readonly ILogger _logger;

        public SimpleBusinessFunctions(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SimpleBusinessFunctions>();
        }

        [Function("Helloworld")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "business/helloworld")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}

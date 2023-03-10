using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;

namespace AzureFunction
{
    public static class AzureFunction
    {
        [FunctionName("GetHelloWord")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get",  Route = null)] HttpRequest req)
        {
            return new OkObjectResult("Hello World!");
        }
    }
}

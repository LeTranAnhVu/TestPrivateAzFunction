using System.Threading.Tasks;
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.FunctionApp5;

public static class QueueTrigger
{
    [FunctionName("QueueTrigger")]
    public static async Task RunAsync([QueueTrigger("myqueue")] string myQueueItem, ILogger log)
    {
        log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        
    }
}

using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Logging;

namespace Demo.MiddleWares
{
    public class StopwhatchMiddleware
    {
        private readonly RequestDelegate _next;

        public StopwhatchMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context, ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger<StopwhatchMiddleware>();

            var stopWhatch = new Stopwatch();
            stopWhatch.Start();

            await _next.Invoke(context);

            stopWhatch.Stop();
            var elapsed = stopWhatch.Elapsed;

            logger.LogInformation($"Request time: {elapsed.Milliseconds}");
            await context.Response.WriteAsync($"<!-- Request time: {elapsed.Milliseconds} -->");
        }
    }
}
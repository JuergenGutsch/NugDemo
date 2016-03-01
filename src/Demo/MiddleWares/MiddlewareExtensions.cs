using Microsoft.AspNet.Builder;

namespace Demo.MiddleWares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseStopwhatchMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<StopwhatchMiddleware>();
        }
    }
}
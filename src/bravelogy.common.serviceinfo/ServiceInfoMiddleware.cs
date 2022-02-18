using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;


namespace Bravelogy.Common.ServiceInfo
{
    public class ServiceInfoMiddleware
    {
        private readonly RequestDelegate _next;

        public ServiceInfoMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("Hello from non-Map delegate. <p>");
        }
    }
}

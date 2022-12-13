using Microsoft.AspNetCore.Builder;
using WEB_053505_HRIGORCHUK.Middleware;

namespace WEB_053505_HRIGORCHUK.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}

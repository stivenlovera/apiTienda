using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Middelwares
{
    public static class ResponseLogMiddelwareExtensions
    {
        public static IApplicationBuilder UseLogResponse(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ResponseLogMiddelware>();
        }
    }
    public class ResponseLogMiddelware
    {
        private RequestDelegate _next { get; set; }
        public ResponseLogMiddelware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context, ILogger<ResponseLogMiddelware> logger)
        {
            using (var ms = new MemoryStream())
            {
                var bodyResponse = context.Response.Body;
                context.Response.Body = ms;

                await _next(context);

                ms.Seek(0, SeekOrigin.Begin);
                string respuesta = new StreamReader(ms).ReadToEnd();
                ms.Seek(0, SeekOrigin.Begin);

                await ms.CopyToAsync(bodyResponse);
                context.Response.Body = bodyResponse;

                logger.LogInformation(respuesta + "esto es un log desde startup");
            }
        }
    }
}
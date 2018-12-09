using System;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace WebApiConsole
{
    public class LoggingMiddleware : OwinMiddleware
    {
        public LoggingMiddleware(OwinMiddleware next)
            : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            Console.WriteLine($"{context.Request.Uri.ToString()}");

            await Next.Invoke(context);

            Console.WriteLine($"{context.Response.StatusCode.ToString()}");

            //handle response logging
        }

    }
}

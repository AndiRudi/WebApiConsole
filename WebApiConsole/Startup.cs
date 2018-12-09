using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApiConsole.Startup))]

namespace WebApiConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Console.WriteLine("Starting up " + DateTime.Now.ToString());
            app.Use<LoggingMiddleware>();
            app.UseWelcomePage();
        }
    }
}
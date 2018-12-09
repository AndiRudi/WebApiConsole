using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://*:5000";
            using (WebApp.Start<Startup>(baseUrl))
            {
                Console.WriteLine($"Serving under Port {baseUrl}");

                Console.WriteLine("Press CTRL+C to exit");

                Thread.Sleep(Timeout.Infinite);

                Console.WriteLine("Exiting...");
            }
        }
    }
}
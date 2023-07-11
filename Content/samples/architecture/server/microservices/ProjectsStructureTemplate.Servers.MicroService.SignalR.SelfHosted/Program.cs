
namespace ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted
{
    using System;

    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.Hosting;

    class Program
    {
        static void
                                        Main
                                            (
                                                string[] args
                                            )
        {
            CreateHostBuilder(args).Build().Run();

            return;
        }

        private static
            IHostBuilder
                                        CreateHostBuilder
                                            (
                                                string[] args
                                            )
            =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults
                        (
                            webBuilder =>
                            {
                                webBuilder.UseStartup<Startup>();
                            }
                        );
    }
}
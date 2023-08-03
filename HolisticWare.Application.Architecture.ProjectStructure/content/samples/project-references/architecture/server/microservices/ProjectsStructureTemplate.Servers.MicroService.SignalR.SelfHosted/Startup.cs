
namespace ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class
                                        Startup
    {
        public
            IConfiguration
                                        Configuration
        {
            get;
        }

        public
                                        Startup
                                            (
                                                IConfiguration configuration
                                            )
        {
            Configuration = configuration;

            return;
        }

        public void
                                        ConfigureServices
                                            (
                                                IServiceCollection services
                                            )
        {
            services.AddSignalR();

            return;
        }

        public void
                                        Configure
                                            (
                                                IApplicationBuilder app
                                            )
        {
            app.UseRouting();
            app.UseEndpoints
                        (
                            endpoints =>
                            {
                                endpoints.MapHub<Hubs.Chat>("/signalr/hubs/chat");
                            }
                        );

            return;
        }
    }
}
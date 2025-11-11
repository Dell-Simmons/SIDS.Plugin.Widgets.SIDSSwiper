using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using SIDS.Plugin.Widgets.SIDSSwiper.Factories;

namespace SIDS.Plugin.Widgets.SIDSSwiper.Infrastructure
{
    public class PluginNopStartup : INopStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
         

            services.AddScoped<SlideModelFactory>();
         
        }

        public void Configure(IApplicationBuilder application)
        {
        }

        public int Order => 666666;//11;
    }
}
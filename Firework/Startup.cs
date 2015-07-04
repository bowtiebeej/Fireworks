using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(Firework.Startup))]

namespace Firework
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.UseRedis("unclebjsfireworks.redis.cache.windows.net", 6379, "lFIzvIvRAMLKoIk254DLzKRdDfBh2OOvdW8yWLMDRG4=", "Fireworks");
            app.MapSignalR();
        }
    }
}

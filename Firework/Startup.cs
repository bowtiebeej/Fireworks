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
            GlobalHost.DependencyResolver.UseRedis("unclebjsfireworks.redis.cache.windows.net", 6379, "YTzLtcUbSXOilidcAbMl2kIZSTjwxHKFSqKcEVDco/o=", "Fireworks");
            app.MapSignalR();
        }
    }
}

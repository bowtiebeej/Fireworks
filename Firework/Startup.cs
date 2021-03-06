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
            GlobalHost.DependencyResolver.UseRedis("fourthofjuly.redis.cache.windows.net", 6379, "2nW2uzqOXKooqMBUl5OwgXyUz+cXsKpkEXhxkN7283M=", "Fireworks");
            app.MapSignalR();
        }
    }
}

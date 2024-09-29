using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(RealTimeChat.Startup))]
namespace RealTimeChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure SignalR
            app.MapSignalR();
        }
    }
}


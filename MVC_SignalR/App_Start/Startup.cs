using Microsoft.Owin;
using MVC_SignalR;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace MVC_SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}

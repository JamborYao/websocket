using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSocketClient.Startup))]
namespace WebSocketClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

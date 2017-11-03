using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebWorker.Startup))]
namespace WebWorker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

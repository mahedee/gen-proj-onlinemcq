using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineMCQ.Startup))]
namespace OnlineMCQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlCarga.Startup))]
namespace ControlCarga
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

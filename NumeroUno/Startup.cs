using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumeroUno.Startup))]
namespace NumeroUno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

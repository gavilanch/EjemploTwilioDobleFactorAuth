using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploTwilio.Startup))]
namespace EjemploTwilio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArarAirport.Startup))]
namespace ArarAirport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

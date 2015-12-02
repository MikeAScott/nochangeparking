using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoChangeParking.Startup))]
namespace NoChangeParking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

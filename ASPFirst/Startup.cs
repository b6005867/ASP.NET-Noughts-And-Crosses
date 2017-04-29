using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPFirst.Startup))]
namespace ASPFirst
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

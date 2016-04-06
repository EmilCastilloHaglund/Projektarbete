using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OruProjekt.Startup))]
namespace OruProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

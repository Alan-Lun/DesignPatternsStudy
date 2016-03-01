using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesignPatterns_Study.Startup))]
namespace DesignPatterns_Study
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

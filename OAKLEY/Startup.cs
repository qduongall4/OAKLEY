using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAKLEY.Startup))]
namespace OAKLEY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

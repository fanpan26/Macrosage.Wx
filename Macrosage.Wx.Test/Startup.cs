using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pz.Weixin.Test.Startup))]
namespace Pz.Weixin.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

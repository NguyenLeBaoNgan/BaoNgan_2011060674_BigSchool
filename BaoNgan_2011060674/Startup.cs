using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaoNgan_2011060674.Startup))]
namespace BaoNgan_2011060674
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

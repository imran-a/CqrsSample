using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CqrsSample.Startup))]
namespace CqrsSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

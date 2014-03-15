using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcEnumDemo.Startup))]
namespace MvcEnumDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

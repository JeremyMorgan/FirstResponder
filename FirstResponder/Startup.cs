using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstResponder.Startup))]
namespace FirstResponder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

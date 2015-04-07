using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(First_Responder.Startup))]
namespace First_Responder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

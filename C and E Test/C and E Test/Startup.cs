using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C_and_E_Test.Startup))]
namespace C_and_E_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

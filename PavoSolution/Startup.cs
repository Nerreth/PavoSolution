using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PavoSolution.Startup))]
namespace PavoSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

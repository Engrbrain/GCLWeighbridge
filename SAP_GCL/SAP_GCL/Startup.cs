using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAP_GCL.Startup))]
namespace SAP_GCL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

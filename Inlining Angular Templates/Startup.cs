using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InliningAngularTemplates.Startup))]
namespace InliningAngularTemplates
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}

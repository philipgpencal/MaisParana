using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaisParana.Web.Startup))]
namespace MaisParana.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}

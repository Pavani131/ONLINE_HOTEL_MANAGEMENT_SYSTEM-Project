using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_HotelManagement.Startup))]
namespace MVC_HotelManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

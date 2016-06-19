using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMSMovieapp.Startup))]
namespace MVCMSMovieapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

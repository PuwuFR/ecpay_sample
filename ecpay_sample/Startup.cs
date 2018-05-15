using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecpay_sample.Startup))]
namespace ecpay_sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

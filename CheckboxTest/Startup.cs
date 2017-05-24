using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckboxTest.Startup))]
namespace CheckboxTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

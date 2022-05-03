using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EncryptPassword.Startup))]
namespace EncryptPassword
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

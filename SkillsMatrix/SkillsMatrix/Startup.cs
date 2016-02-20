using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkillsMatrix.Startup))]
namespace SkillsMatrix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BayShoreSolution_TestQuestion.Startup))]
namespace BayShoreSolution_TestQuestion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

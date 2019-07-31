using Microsoft.Owin;
using Owin;
//using System.Web.Http.Cors;

[assembly: OwinStartupAttribute(typeof(DeCKR_WebAPI.Startup))]
namespace DeCKR_WebAPI
{
   // [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            
            ConfigureAuth(app);
        }
    }
}

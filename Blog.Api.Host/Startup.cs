using System.Web.Http;
using Owin;

namespace Blogger.Api.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = GlobalConfiguration.Configuration;
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("default","api/{controller}/{id}",new {id=RouteParameter.Optional});
            app.UseWebApi(config);

            
        }
    }
}
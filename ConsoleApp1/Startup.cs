using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApp1
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "CustomApi",
                routeTemplate: "{action}",
                defaults: new { controller = "Optly", id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }
    }
}

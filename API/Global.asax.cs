using System.Web;
using System.Web.Http;
using API.App_Start;

namespace API {
	public class WebApiApplication : HttpApplication {
		protected void Application_Start() {
			GlobalConfiguration.Configure(WebApiConfig.Register);
			AutoMapperConfig.RegisterMappings();
		}
	}
}
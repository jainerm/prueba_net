using System.Web.Routing;

namespace paginamaestra
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object GlobalFilters { get; private set; }

        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

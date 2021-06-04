using System.Web;
using System.Web.Mvc;

namespace paginamaestra
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
        }
    }

    internal class HandleErrorAttribute
    {
        public HandleErrorAttribute()
        {
        }
    }

    public class GlobalFilterCollection
    {
    }
}

using System.Web;
using System.Web.Mvc;

namespace FrameworkMVC_OnlineDatingSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

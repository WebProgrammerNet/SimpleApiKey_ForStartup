using System.Web;
using System.Web.Mvc;

namespace SimpleApiKey_ForStartup
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace _5951071077_TranDuyPhuc_Weather
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

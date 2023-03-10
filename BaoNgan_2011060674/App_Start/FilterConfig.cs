using System.Web;
using System.Web.Mvc;

namespace BaoNgan_2011060674
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

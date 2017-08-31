using System.Web;
using System.Web.Mvc;

namespace BayShoreSolution_TestQuestion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
